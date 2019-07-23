import Home from "./component/home";
import Artists from "./component/Artists";
import Albums from "./component/Albums";
import Songs from "./component/Songs";
import ApiAction from "./api/api-actions";
import AlbumsByArtist from "./component/AlbumsByArtist";
import SongByAlbum from "./component/SongByAlbum";

pageBuild();

function pageBuild(){
    home();
    artists();
    albums();
    songs();
    albumsbyartist();
    songbyalbum();
}

function home(){
    const app = document.getElementById('app');
    const home = document.getElementById('nav__Home');
    home.addEventListener('click', function(){
        app.innerHTML = Home();
    })
};

function artists(){
    const app = document.getElementById('app');
    const artists = document.getElementById('nav__Artists');
    artists.addEventListener('click', function(){
        ApiAction.getRequest("https://localhost:44378/api/artists", artistlist => {
            app.innerHTML = Artists(artistlist);
        })
    })

    document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('add-artist_submit')){
            const artist = event.target.parentElement.querySelector('.add-artist_artistname').value;
            const artistimage = event.target.parentElement.querySelector('.add-artist_artistimage').value;
            const data = {
                artistId: 0,
                artistName: artist,
                ImageUrl: artistimage
            }
            ApiAction.postRequest("https://localhost:44378/api/artists", data, artistlist => {
                document.querySelector('#app').innerHTML = Artists(artistlist);
            })
        }
    })

    
      document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("delete-artistId__delete")) {
          const artist = event.target.parentElement.querySelector(".delete-artist__id")
            .value;
          ApiAction.deleteRequest("https://localhost:44378/api/artists/"+ artist,artist,
            artists => {
                document.querySelector('#app').innerHTML = Artists(artists);
            },           
            );
        }
      });

      document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('edit-artist_submit')){
            const artist = event.target.parentElement.querySelector('.edit-artist__artistId').value;
            // const artistimage = event.target.parentElement.querySelector('.edit-artist_artistimage').value;
            const name = event.target.parentElement.querySelector('.edit-artist_name').value;
            const data = {
                artistId: artist,
                artistName: name,
                // ImageUrl: artistimage
            }
            ApiAction.putRequest("https://localhost:44378/api/artists/"+ artist, data, artistlist => {
                document.querySelector('#app').innerHTML = Artists(artistlist);
            })
        }
    })
      
      
        
        
};
function albums(){
    const app = document.getElementById('app');
    const albums = document.getElementById('nav__Albums');
    albums.addEventListener('click', function(){
        ApiAction.getRequest("https://localhost:44378/api/albums", albumlist => {
            app.innerHTML = Albums(albumlist);
        })
    }) 
        
    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-albumId__select")) {
        const albumId = event.target.parentElement.querySelector(".select-album__id")
            .value;
            console.log(albumId)
        ApiAction.getRequest("https://localhost:44378/api/songs/"+ albumId,
            albums => {
                document.querySelector('#app').innerHTML = SongByAlbum(albums);
        },           
        );
    }
  });
}

function albumsbyartist(){
    
    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-artistId__select")) {
          const artistId = event.target.parentElement.querySelector(".select-artist__id")
            .value;
            console.log(artistId)
          ApiAction.getRequest("https://localhost:44378/api/albums/"+ artistId,
            albums => {
                document.querySelector('#app').innerHTML = AlbumsByArtist(albums, artistId);
            },           
            );
        }
      });

      document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('add-album_submit')){
           const artist = event.target.parentElement.querySelector('.add-album_artistId').value;
           const album = event.target.parentElement.querySelector('.add-album_albumname').value;
           const albumimage = event.target.parentElement.querySelector('.add-album_albumimage').value;
           const data = {
           artistId: artist, 
           albumId: 0,
           albumTitle: album,
           imageUrl: albumimage
           }
           ApiAction.postRequest("https://localhost:44378/api/albums", data, albumlist => {
            document.querySelector('#app').innerHTML = Albums(albumlist);
           })
       }
   })

   document.querySelector('#app').addEventListener("click", function() {
    if (event.target.classList.contains("delete-albumId__delete")) {
      const album = event.target.parentElement.querySelector(".delete-album__id")
        .value;
      ApiAction.deleteRequest("https://localhost:44378/api/albums/"+ album, album,
        albums => {
            document.querySelector('#app').innerHTML = Albums(albums);
        },           
        );
    }
  });

  document.querySelector('#app').addEventListener("click", function(){
    if(event.target.classList.contains('edit-album_submit')){
        const artist = event.target.parentElement.querySelector('.edit-album_artistId').value;
        const album = event.target.parentElement.querySelector('.edit-album__albumId').value;
        // const albumimage = event.target.parentElement.querySelector('.edit-album_albumimage').value;
        const name = event.target.parentElement.querySelector('.edit-album_name').value;
        const label = event.target.parentElement.querySelector('.edit-album_label').value;
        const data = {
            artistId: artist,
            albumId: album,
            albumTitle: name,
            recordLabel: label
            // ImageUrl: albumimage
        }
    ApiAction.putRequest("https://localhost:44378/api/albums/"+ album, data, albumlist => {
        document.querySelector('#app').innerHTML = Albums(albumlist);
    })
    }
})

}

function songbyalbum(){
    
    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-albumId__select")) {
          const albumId = event.target.parentElement.querySelector(".select-album__id")
            .value;
            console.log(albumId)
          ApiAction.getRequest("https://localhost:44378/api/songs/"+ albumId,
            albums => {
                document.querySelector('#app').innerHTML = SongByAlbum(albums);
            },           
            );
        }
      });

}

function songs(){
    const app = document.getElementById('app');
    const songs = document.getElementById('nav__Songs');
    songs.addEventListener('click', function(){
        ApiAction.getRequest("https://localhost:44378/api/songs", songlist => {
            app.innerHTML = Songs(songlist);
        })
    })
};

