// modules are defined as an array
// [ module function, map of requires ]
//
// map of requires is short require name -> numeric require
//
// anything defined in a previous bundle is accessed via the
// orig method which is the require for previous bundles
parcelRequire = (function (modules, cache, entry, globalName) {
  // Save the require from previous bundle to this closure if any
  var previousRequire = typeof parcelRequire === 'function' && parcelRequire;
  var nodeRequire = typeof require === 'function' && require;

  function newRequire(name, jumped) {
    if (!cache[name]) {
      if (!modules[name]) {
        // if we cannot find the module within our internal map or
        // cache jump to the current global require ie. the last bundle
        // that was added to the page.
        var currentRequire = typeof parcelRequire === 'function' && parcelRequire;
        if (!jumped && currentRequire) {
          return currentRequire(name, true);
        }

        // If there are other bundles on this page the require from the
        // previous one is saved to 'previousRequire'. Repeat this as
        // many times as there are bundles until the module is found or
        // we exhaust the require chain.
        if (previousRequire) {
          return previousRequire(name, true);
        }

        // Try the node require function if it exists.
        if (nodeRequire && typeof name === 'string') {
          return nodeRequire(name);
        }

        var err = new Error('Cannot find module \'' + name + '\'');
        err.code = 'MODULE_NOT_FOUND';
        throw err;
      }

      localRequire.resolve = resolve;
      localRequire.cache = {};

      var module = cache[name] = new newRequire.Module(name);

      modules[name][0].call(module.exports, localRequire, module, module.exports, this);
    }

    return cache[name].exports;

    function localRequire(x){
      return newRequire(localRequire.resolve(x));
    }

    function resolve(x){
      return modules[name][1][x] || x;
    }
  }

  function Module(moduleName) {
    this.id = moduleName;
    this.bundle = newRequire;
    this.exports = {};
  }

  newRequire.isParcelRequire = true;
  newRequire.Module = Module;
  newRequire.modules = modules;
  newRequire.cache = cache;
  newRequire.parent = previousRequire;
  newRequire.register = function (id, exports) {
    modules[id] = [function (require, module) {
      module.exports = exports;
    }, {}];
  };

  var error;
  for (var i = 0; i < entry.length; i++) {
    try {
      newRequire(entry[i]);
    } catch (e) {
      // Save first error but execute all entries
      if (!error) {
        error = e;
      }
    }
  }

  if (entry.length) {
    // Expose entry point to Node, AMD or browser globals
    // Based on https://github.com/ForbesLindesay/umd/blob/master/template.js
    var mainExports = newRequire(entry[entry.length - 1]);

    // CommonJS
    if (typeof exports === "object" && typeof module !== "undefined") {
      module.exports = mainExports;

    // RequireJS
    } else if (typeof define === "function" && define.amd) {
     define(function () {
       return mainExports;
     });

    // <script>
    } else if (globalName) {
      this[globalName] = mainExports;
    }
  }

  // Override the current require with this new one
  parcelRequire = newRequire;

  if (error) {
    // throw error from earlier, _after updating parcelRequire_
    throw error;
  }

  return newRequire;
})({"js/component/home.js":[function(require,module,exports) {
"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.default = Home;

function Home() {
  return "\n<h1>PressPlay</h1>\n";
}

;
},{}],"js/component/Artists.js":[function(require,module,exports) {
"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.default = Artists;

function Artists(artistlist) {
  return "\n    <h1>Artists</h1>\n    <ul>\n        ".concat(artistlist.map(function (artist) {
    return "\n            <li>\n                <p>".concat(artist.artistName, "</p>\n                <img src=").concat(artist.imageUrl, ">\n                <input class='delete-artist__id' type='hidden' value=\"").concat(artist.artistId, "\">\n                <button class='delete-artistId__delete'>Delete Artist</button> \n                <input class='select-artist__id' type='hidden' value=\"").concat(artist.artistId, "\">\n                <button class='select-artistId__select'>Select Artist</button>    \n                \n                \n                <section> \n                <input class='edit-artist__artistId' type='hidden' value=\"").concat(artist.artistId, "\">\n                <input type=\"text\" class=\"edit-artist_name\" placeholder=\"Edit an artist name.\">\n                <button class=\"edit-artist_submit\">Submit</button>\n                </section>          \n            </li>\n        ");
  }).join(""), "\n\n        </ul>\n        <section> \n            <input type=\"text\" class=\"add-artist_artistname\" placeholder=\"Add an artist name.\">\n            <input type=\"text\" class=\"add-artist_artistimage\" placeholder=\"Add an artist Image.\">\n            <button class=\"add-artist_submit\"> Submit</button>\n        </section>\n\n        \n\n\n\n    ");
}

;
},{}],"js/component/Albums.js":[function(require,module,exports) {
"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.default = Albums;

function Albums(albumlist) {
  return "\n    <h1>Albums</h1>\n    <ul>\n        ".concat(albumlist.map(function (album) {
    return "\n            <li>\n                <p>".concat(album.albumTitle, "</p>\n                <img src=\"").concat(album.imageUrl, "\">\n                <p>").concat(album.recordLabel, "</p>   \n                <input class='delete-album__id' type='hidden' value=\"").concat(album.albumId, "\">\n                <button class='delete-albumId__delete'>Delete Album</button> \n                <input class='select-album__id' type='hidden' value=\"").concat(album.albumId, "\">\n                <button class='select-albumId__select'>Select Album</button>    \n                \n                \n                <section> \n                <input class='edit-album__albumId' type='hidden' value=\"").concat(album.albumId, "\">\n                <input type=\"text\" class=\"edit-album_name\" placeholder=\"Edit an album name.\">\n                <button class=\"edit-album_submit\">Submit</button>\n                </section>                      \n            </li>\n        ");
  }).join(""), "\n    </ul>\n    <section> \n            <input type=\"text\" class=\"add-album_albumname\" placeholder=\"Add an album title.\">\n            <input type=\"text\" class=\"add-album_albumimage\" placeholder=\"Add an album Image.\">\n            <button class=\"add-album_submit\"> Submit</button>\n        </section>\n");
}

;
},{}],"js/component/Songs.js":[function(require,module,exports) {
"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.default = Songs;

function Songs(songlist) {
  return "\n    <h1>Songs</h1>\n    <ul>\n    ".concat(songlist.map(function (song) {
    return "\n        <li>\n            <p> ".concat(song.songTitle, "</p>\n            <p>").concat(song.songId, "</p>   \n            <p>").concat(song.duration, "</p>\n            <a href = \"").concat(song.link, "\">YouTube Link</a>         \n        </li>\n    ");
  }).join(""), "\n    </ul>\n");
}

;
},{}],"js/api/api-actions.js":[function(require,module,exports) {
"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.default = void 0;

function getRequest(location, callback) {
  fetch(location).then(function (response) {
    return response.json();
  }).then(function (jsonData) {
    return callback(jsonData);
  }).catch(function (err) {
    return console.log(err);
  });
}

function postRequest(location, requestBody, callback) {
  fetch(location, {
    method: "POST",
    body: JSON.stringify(requestBody),
    headers: {
      "Content-Type": "application/json"
    }
  }).then(function (response) {
    return response.json();
  }).then(function (jsonData) {
    return callback(jsonData);
  }).catch(function (err) {
    return console.log(err);
  });
}

function deleteRequest(location, requestBody, callback) {
  fetch(location, {
    method: "DELETE",
    body: JSON.stringify(requestBody),
    headers: {
      "Content-Type": "application/json"
    }
  }).then(function (response) {
    return response.json();
  }).then(function (data) {
    return callback(data);
  }).catch(function (err) {
    return console.log(err);
  });
}

function putRequest(location, requestBody, callback) {
  fetch(location, {
    method: "PUT",
    body: JSON.stringify(requestBody),
    headers: {
      "Content-Type": "application/json"
    }
  }).then(function (response) {
    return response.json();
  }).then(function (jsonData) {
    return callback(jsonData);
  }).catch(function (err) {
    return console.log(err);
  });
}

var _default = {
  getRequest: getRequest,
  postRequest: postRequest,
  deleteRequest: deleteRequest,
  putRequest: putRequest
};
exports.default = _default;
},{}],"js/component/AlbumsByArtist.js":[function(require,module,exports) {
"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.default = AlbumsByArtist;

function AlbumsByArtist(albumsbyid) {
  return "\n    \n    <ul>\n    ".concat(albumsbyid.map(function (album) {
    return "\n        \n        <li>\n            <p>".concat(album.albumTitle, "</p>\n            <img src=\"").concat(album.imageUrl, "\">\n            <p>").concat(album.recordLabel, "</p>  \n            <input class='select-album__id' type='hidden' value=\"").concat(album.albumId, "\">\n            <button class='select-albumId__select'>Select Album</button>                                      \n        </li>\n    ");
  }).join(""), "\n    </ul>\n    ");
}

;
},{}],"js/component/SongByAlbum.js":[function(require,module,exports) {
"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.default = SongByArtist;

function SongByArtist(songbyid) {
  return "\n    \n    <ul>\n    ".concat(songbyid.map(function (song) {
    return "\n        <h2> Selected Album</h2>\n        <li>\n            <p>".concat(song.songTitle, "</p>                                     \n        </li>\n    ");
  }).join(""), "\n    </ul>\n    ");
}

;
},{}],"js/app.js":[function(require,module,exports) {
"use strict";

var _home = _interopRequireDefault(require("./component/home"));

var _Artists = _interopRequireDefault(require("./component/Artists"));

var _Albums = _interopRequireDefault(require("./component/Albums"));

var _Songs = _interopRequireDefault(require("./component/Songs"));

var _apiActions = _interopRequireDefault(require("./api/api-actions"));

var _AlbumsByArtist = _interopRequireDefault(require("./component/AlbumsByArtist"));

var _SongByAlbum = _interopRequireDefault(require("./component/SongByAlbum"));

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

pageBuild();

function pageBuild() {
  home();
  artists();
  albums();
  songs();
  albumsbyartist();
  songbyalbum();
}

function home() {
  var app = document.getElementById('app');
  var home = document.getElementById('nav__Home');
  home.addEventListener('click', function () {
    app.innerHTML = (0, _home.default)();
  });
}

;

function artists() {
  var app = document.getElementById('app');
  var artists = document.getElementById('nav__Artists');
  artists.addEventListener('click', function () {
    _apiActions.default.getRequest("https://localhost:44378/api/artists", function (artistlist) {
      app.innerHTML = (0, _Artists.default)(artistlist);
    });
  });
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains('add-artist_submit')) {
      var artist = event.target.parentElement.querySelector('.add-artist_artistname').value;
      var artistimage = event.target.parentElement.querySelector('.add-artist_artistimage').value;
      var data = {
        artistId: 0,
        artistName: artist,
        ImageUrl: artistimage
      };

      _apiActions.default.postRequest("https://localhost:44378/api/artists", data, function (artistlist) {
        document.querySelector('#app').innerHTML = (0, _Artists.default)(artistlist);
      });
    }
  });
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains("delete-artistId__delete")) {
      var artist = event.target.parentElement.querySelector(".delete-artist__id").value;

      _apiActions.default.deleteRequest("https://localhost:44378/api/artists/" + artist, artist, function (artists) {
        document.querySelector('#app').innerHTML = (0, _Artists.default)(artists);
      });
    }
  });
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains('edit-artist_submit')) {
      var artist = event.target.parentElement.querySelector('.edit-artist__artistId').value; // const artistimage = event.target.parentElement.querySelector('.edit-artist_artistimage').value;

      var name = event.target.parentElement.querySelector('.edit-artist_name').value;
      var data = {
        artistId: artist,
        artistName: name // ImageUrl: artistimage

      };

      _apiActions.default.putRequest("https://localhost:44378/api/artists/" + artist, data, function (artistlist) {
        document.querySelector('#app').innerHTML = (0, _Artists.default)(artistlist);
      });
    }
  });
}

;

function albums() {
  var app = document.getElementById('app');
  var albums = document.getElementById('nav__Albums');
  albums.addEventListener('click', function () {
    _apiActions.default.getRequest("https://localhost:44378/api/albums", function (albumlist) {
      app.innerHTML = (0, _Albums.default)(albumlist);
    });
  });
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains('add-album_submit')) {
      var album = event.target.parentElement.querySelector('.add-album_albumname').value;
      var albumimage = event.target.parentElement.querySelector('.add-album_albumimage').value;
      var data = {
        albumId: 0,
        albumName: album,
        ImageUrl: albumimage
      };

      _apiActions.default.postRequest("https://localhost:44378/api/albums", data, function (albumlist) {
        document.querySelector('#app').innerHTML = (0, _Albums.default)(albumlist);
      });
    }
  });
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains("delete-albumId__delete")) {
      var album = event.target.parentElement.querySelector(".delete-album__id").value;

      _apiActions.default.deleteRequest("https://localhost:44378/api/albums/" + album, album, function (albums) {
        document.querySelector('#app').innerHTML = (0, _Albums.default)(albums);
      });
    }
  });
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains('edit-album_submit')) {
      var album = event.target.parentElement.querySelector('.edit-album__albumId').value; // const albumimage = event.target.parentElement.querySelector('.edit-album_albumimage').value;

      var name = event.target.parentElement.querySelector('.edit-album_name').value;
      var data = {
        albumId: album,
        albumName: name // ImageUrl: albumimage

      };

      _apiActions.default.putRequest("https://localhost:44378/api/albums/" + album, data, function (albumlist) {
        document.querySelector('#app').innerHTML = (0, _Albums.default)(albumlist);
      });
    }
  });
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains("select-albumId__select")) {
      var albumId = event.target.parentElement.querySelector(".select-album__id").value;
      console.log(albumId);

      _apiActions.default.getRequest("https://localhost:44378/api/songs/" + albumId, function (albums) {
        document.querySelector('#app').innerHTML = (0, _SongByAlbum.default)(albums);
      });
    }
  });
}

function albumsbyartist() {
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains("select-artistId__select")) {
      var artistId = event.target.parentElement.querySelector(".select-artist__id").value;
      console.log(artistId);

      _apiActions.default.getRequest("https://localhost:44378/api/albums/" + artistId, function (artists) {
        document.querySelector('#app').innerHTML = (0, _AlbumsByArtist.default)(artists);
      });
    }
  });
}

function songbyalbum() {
  document.querySelector('#app').addEventListener("click", function () {
    if (event.target.classList.contains("select-albumId__select")) {
      var albumId = event.target.parentElement.querySelector(".select-album__id").value;
      console.log(albumId);

      _apiActions.default.getRequest("https://localhost:44378/api/songs/" + albumId, function (albums) {
        document.querySelector('#app').innerHTML = (0, _SongByAlbum.default)(albums);
      });
    }
  });
}

function songs() {
  var app = document.getElementById('app');
  var songs = document.getElementById('nav__Songs');
  songs.addEventListener('click', function () {
    _apiActions.default.getRequest("https://localhost:44378/api/songs", function (songlist) {
      app.innerHTML = (0, _Songs.default)(songlist);
    });
  });
}

;
},{"./component/home":"js/component/home.js","./component/Artists":"js/component/Artists.js","./component/Albums":"js/component/Albums.js","./component/Songs":"js/component/Songs.js","./api/api-actions":"js/api/api-actions.js","./component/AlbumsByArtist":"js/component/AlbumsByArtist.js","./component/SongByAlbum":"js/component/SongByAlbum.js"}],"node_modules/parcel-bundler/src/builtins/hmr-runtime.js":[function(require,module,exports) {
var global = arguments[3];
var OVERLAY_ID = '__parcel__error__overlay__';
var OldModule = module.bundle.Module;

function Module(moduleName) {
  OldModule.call(this, moduleName);
  this.hot = {
    data: module.bundle.hotData,
    _acceptCallbacks: [],
    _disposeCallbacks: [],
    accept: function (fn) {
      this._acceptCallbacks.push(fn || function () {});
    },
    dispose: function (fn) {
      this._disposeCallbacks.push(fn);
    }
  };
  module.bundle.hotData = null;
}

module.bundle.Module = Module;
var checkedAssets, assetsToAccept;
var parent = module.bundle.parent;

if ((!parent || !parent.isParcelRequire) && typeof WebSocket !== 'undefined') {
  var hostname = "" || location.hostname;
  var protocol = location.protocol === 'https:' ? 'wss' : 'ws';
  var ws = new WebSocket(protocol + '://' + hostname + ':' + "57217" + '/');

  ws.onmessage = function (event) {
    checkedAssets = {};
    assetsToAccept = [];
    var data = JSON.parse(event.data);

    if (data.type === 'update') {
      var handled = false;
      data.assets.forEach(function (asset) {
        if (!asset.isNew) {
          var didAccept = hmrAcceptCheck(global.parcelRequire, asset.id);

          if (didAccept) {
            handled = true;
          }
        }
      }); // Enable HMR for CSS by default.

      handled = handled || data.assets.every(function (asset) {
        return asset.type === 'css' && asset.generated.js;
      });

      if (handled) {
        console.clear();
        data.assets.forEach(function (asset) {
          hmrApply(global.parcelRequire, asset);
        });
        assetsToAccept.forEach(function (v) {
          hmrAcceptRun(v[0], v[1]);
        });
      } else {
        window.location.reload();
      }
    }

    if (data.type === 'reload') {
      ws.close();

      ws.onclose = function () {
        location.reload();
      };
    }

    if (data.type === 'error-resolved') {
      console.log('[parcel] ✨ Error resolved');
      removeErrorOverlay();
    }

    if (data.type === 'error') {
      console.error('[parcel] 🚨  ' + data.error.message + '\n' + data.error.stack);
      removeErrorOverlay();
      var overlay = createErrorOverlay(data);
      document.body.appendChild(overlay);
    }
  };
}

function removeErrorOverlay() {
  var overlay = document.getElementById(OVERLAY_ID);

  if (overlay) {
    overlay.remove();
  }
}

function createErrorOverlay(data) {
  var overlay = document.createElement('div');
  overlay.id = OVERLAY_ID; // html encode message and stack trace

  var message = document.createElement('div');
  var stackTrace = document.createElement('pre');
  message.innerText = data.error.message;
  stackTrace.innerText = data.error.stack;
  overlay.innerHTML = '<div style="background: black; font-size: 16px; color: white; position: fixed; height: 100%; width: 100%; top: 0px; left: 0px; padding: 30px; opacity: 0.85; font-family: Menlo, Consolas, monospace; z-index: 9999;">' + '<span style="background: red; padding: 2px 4px; border-radius: 2px;">ERROR</span>' + '<span style="top: 2px; margin-left: 5px; position: relative;">🚨</span>' + '<div style="font-size: 18px; font-weight: bold; margin-top: 20px;">' + message.innerHTML + '</div>' + '<pre>' + stackTrace.innerHTML + '</pre>' + '</div>';
  return overlay;
}

function getParents(bundle, id) {
  var modules = bundle.modules;

  if (!modules) {
    return [];
  }

  var parents = [];
  var k, d, dep;

  for (k in modules) {
    for (d in modules[k][1]) {
      dep = modules[k][1][d];

      if (dep === id || Array.isArray(dep) && dep[dep.length - 1] === id) {
        parents.push(k);
      }
    }
  }

  if (bundle.parent) {
    parents = parents.concat(getParents(bundle.parent, id));
  }

  return parents;
}

function hmrApply(bundle, asset) {
  var modules = bundle.modules;

  if (!modules) {
    return;
  }

  if (modules[asset.id] || !bundle.parent) {
    var fn = new Function('require', 'module', 'exports', asset.generated.js);
    asset.isNew = !modules[asset.id];
    modules[asset.id] = [fn, asset.deps];
  } else if (bundle.parent) {
    hmrApply(bundle.parent, asset);
  }
}

function hmrAcceptCheck(bundle, id) {
  var modules = bundle.modules;

  if (!modules) {
    return;
  }

  if (!modules[id] && bundle.parent) {
    return hmrAcceptCheck(bundle.parent, id);
  }

  if (checkedAssets[id]) {
    return;
  }

  checkedAssets[id] = true;
  var cached = bundle.cache[id];
  assetsToAccept.push([bundle, id]);

  if (cached && cached.hot && cached.hot._acceptCallbacks.length) {
    return true;
  }

  return getParents(global.parcelRequire, id).some(function (id) {
    return hmrAcceptCheck(global.parcelRequire, id);
  });
}

function hmrAcceptRun(bundle, id) {
  var cached = bundle.cache[id];
  bundle.hotData = {};

  if (cached) {
    cached.hot.data = bundle.hotData;
  }

  if (cached && cached.hot && cached.hot._disposeCallbacks.length) {
    cached.hot._disposeCallbacks.forEach(function (cb) {
      cb(bundle.hotData);
    });
  }

  delete bundle.cache[id];
  bundle(id);
  cached = bundle.cache[id];

  if (cached && cached.hot && cached.hot._acceptCallbacks.length) {
    cached.hot._acceptCallbacks.forEach(function (cb) {
      cb();
    });

    return true;
  }
}
},{}]},{},["node_modules/parcel-bundler/src/builtins/hmr-runtime.js","js/app.js"], null)
//# sourceMappingURL=/app.c3f9f951.js.map