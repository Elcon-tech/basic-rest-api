function init() {
  //地図を表示するdiv要素のidを設定
  var map = L.map("mapcontainer");
  //地図の中心とズームレベルを指定
  map.setView([35.4, 136], 5);
  //座標の指定
  var mpoint = [
    { pos: [35.643, 139.6722], name: "test1" },
    { pos: [33.1403, 129.9837], name: "test2" },
    { pos: [35.7372, 139.7207], name: "test3" },
    { pos: [35.8627, 139.6072], name: "test4" },
  ];
  //map.setView(mpoint, 15);
  //表示するタイルレイヤのURLとAttributionコントロールの記述を設定して、地図に追加する
  L.tileLayer("https://cyberjapandata.gsi.go.jp/xyz/std/{z}/{x}/{y}.png", {
    attribution:
      "<a href='https://maps.gsi.go.jp/development/ichiran.html' target='_blank'>地理院タイル</a>",
  }).addTo(map);
  //埼玉大学の位置にドラッグ可能なマーカーを地図に追加
  //   L.marker(mpoint, { title: "埼玉大学", draggable: true }).addTo(map);
  //   //桜区役所のマーカーを追加
  //   L.marker([35.8561, 139.6098], { title: "桜区役所" }).addTo(map);
  for (let i = 0; i < mpoint.length; i++) {
    L.marker(mpoint[i].pos, { title: mpoint[i].name, draggable: true }).addTo(
      map
    );
    // console.log(mpoint[i]);
  }
  // Control OSM Geocoder
  var option = {
    position: "topright", // topright, topleft, bottomright, bottomleft
    text: "検索",
    placeholder: "検索条件を入力してください。",
  };
  var osmGeocoder = new L.Control.OSMGeocoder(option);
  map.addControl(osmGeocoder);
}
