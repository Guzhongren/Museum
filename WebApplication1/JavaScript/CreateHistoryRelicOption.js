/**
 * Created by GZR on 2014/12/10.
 */
//创建查询内容
require(['dojo/dom',
    'dojo/dom-construct',
    'dojo/_base/lang',
    'dojo/domReady!'],function(dom,domConstruct,lang){
    $("#txtQueryTime").on("change",lang.hitch(this,function (){
        $("#txtQueryRelic").empty();
        switch($("#txtQueryTime option:selected").text()){
            case "明": domConstruct.place("<option>永乐青花瓷</option><option>隋一</option><option>隋一</option><option>隋一</option><option>隋一</option><option>隋一</option>", "txtQueryRelic");
                break;
            case "唐":domConstruct.place("<option>和田玉</option><option>唐一</option><option>唐一</option><option>唐一</option><option>唐一</option><option>唐一</option>","txtQueryRelic");
                break;
            case "商": domConstruct.place("<option>宋一</option><option>四羊方尊</option><option>宋一</option><option>宋一</option><option>宋一</option><option>宋一</option>", "txtQueryRelic");
                break;
            default:domConstruct.place("<option>默认一</option><option>默认一</option><option>默认一</option><option>默认一</option><option>默认一</option><option>默认一</option>","txtQueryRelic");
                break;
        }
    }));
});
