const videos = ['sample video1', 'sample video2', 'sample video3','sample video4'];

// foreach
videos.forEach(function(video) {
   console.log("run");
   console.log(video);
});

// map
// return 값이 존재한다.
const newVideos = videos.map(function(video) {
   return video.toUpperCase();
});
console.log(newVideos);

// find
const searchTutorial = videos.find(function(video) {
   return video.includes("html");
});
console.log(searchTutorial);

// filter
const shortSearch = videos.filter(function(video) {
   return video.length > 10;
});
console.log(shortSearch);