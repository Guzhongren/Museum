/**
 * Created by GZR on 2014/12/10.
 */
//界面操作
var map;
var dynamicLayer;
var baseUrl ;
var locateButton;
require(["esri/map",
        "esri/layers/ArcGISDynamicMapServiceLayer",
        "esri/dijit/LocateButton",
        "dojo/domReady!"],
    function (Map, DynamicLayer,LocateButton) {
        //加载地图
        map = new Map("map", {
            center: [103.40, 36.05],
            zoom: 10,
            basemap: "streets"
        });
        //定位
        locateButton=new LocateButton({
            map:map,
            scale:11
        },"divLocateButton");
        locateButton.startup();

        map.on("Load", function () {
            consolse.log("已加载地图");
        })
    });