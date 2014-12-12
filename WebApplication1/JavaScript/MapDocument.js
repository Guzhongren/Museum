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

//查询事件处理
$(function () {
    $("#btnSearchRelic").on('click', function () {
        var relicTimeToAshx = $("#txtQueryTime option:selected").text();
        var relicThingToAshx = $("#txtQueryRelic option:selected").text();

        if (relicTimeToAshx == "" || relicThingToAshx == "") {
            $("btnSearchRelic").css("disabled", "false");
            alert("请先选择年代和文物名称！");
        }
        else {
            $.ajax("../Ashx/SearchHistoryRelic.ashx?RelicTimeToAshx=" + relicTimeToAshx + "&RelicThingToAshx=" + relicThingToAshx, {
                type: "post",
                //输出为json,
                dataType: "json",
                success: function (restext) {
                    if (restext == "未选定") {
                        alert("没有数据！");
                    }
                    else {
                        var relicCount = restext.length;
                        if (relicCount <= 0) {
                            alert("数据库中没有数据！请重新选择！！");
                        }
                        else {
                            for (var i = 0; i < relicCount; i++) {
                                //目的：实现图表展示
                                //alert(restext[i].cultrualRelicClassify);
                                //关闭查询窗口
                                $("#Tab1").slideToggle();
                                require(['dojo/_base/lang',
                                         'dojo/dom',
                                         'dojo/domReady!'
                                ], function (lang, dom) {
                                    dom.byId("tbInfo").innerHTML = lang.replace("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td></tr>",
                                            [restext[i].culturalRelicName, restext[i].cultrualRelicClassify,
                                        restext[i].culturalRelicCode, restext[i].culturalRelicMaterrial, restext[i].culturalRelicPosition,
                                        restext[i].culturalRelicBirthPlace, restext[i].cultrualRelicBirthDataTime, restext[i].culturalRelicDataofFigura,
                                        restext[i].culturalRelicBrief]);
                                });
                                $("#info").toggle();

                            }
                        }

                    }

                }
            })
        }

    })
});

