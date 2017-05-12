document.addEventListener('plusready', function(){
   			//console.log("所有plus api都应该在此事件发生后调用，否则会出现plus is undefined。"
   		});
   		
   		var watchId;
   		var urlToWork = "https://api.chelaile.net.cn/bus/line!busesDetail.action?mac=&userId=&userAgent=Mozilla/5.0%20(iPhone;%20CPU%20iPhone%20OS%2010_2_1%20like%20Mac%20OS%20X)%20AppleWebKit/602.4.6%20(KHTML,%20like%20Gecko)%20Mobile/14D27&targetOrder=7&vc=10300&modelVersion=0.0.8&sv=10.2.1&geo_lat=22.541300&geo_lac=65.000000&lorder=1&stats_act=auto_refresh&deviceType=iPhone6s&idfa=631BE84C-7F9A-4719-8624-6FE2B41D2276&lng=113.953122&filter=1&screenHeight=1334&wifi_open=1&stats_order=1-1&sign=cg6JSEXY8MQVgNl2Ol07pQ==&stats_referer=nearby&s=IOS&lat=22.541300&cityId=014&push_open=1&v=5.25.0&geo_type=wgs&lineId=0755-00305-1&cshow=linedetail&language=1&nw=WiFi&lchsrc=icon&udid=833c3610591e326cba55c8f51a2d3f2c390eda1b&geo_lng=113.953122"
   		var urlToHome ="https://api.chelaile.net.cn/bus/line!busesDetail.action?mac=&userId=&userAgent=Mozilla/5.0%20(iPhone;%20CPU%20iPhone%20OS%2010_2_1%20like%20Mac%20OS%20X)%20AppleWebKit/602.4.6%20(KHTML,%20like%20Gecko)%20Mobile/14D27&targetOrder=7&vc=10300&modelVersion=0.0.8&sv=10.2.1&geo_lat=22.541300&geo_lac=65.000000&lorder=1&stats_act=auto_refresh&deviceType=iPhone6s&idfa=631BE84C-7F9A-4719-8624-6FE2B41D2276&lng=113.953122&filter=1&screenHeight=1334&wifi_open=1&stats_order=1-1&sign=cg6JSEXY8MQVgNl2Ol07pQ==&stats_referer=nearby&s=IOS&lat=22.541300&cityId=014&push_open=1&v=5.25.0&geo_type=wgs&lineId=0755-00305-0&cshow=linedetail&language=1&nw=WiFi&lchsrc=icon&udid=833c3610591e326cba55c8f51a2d3f2c390eda1b&geo_lng=113.953122"
   		
   		function createMsg(str){
   			var options = {cover:false};
			plus.push.createMessage( str, "LocalMSG", options );
   		}
   		
   		function getBus(){
   			$.get(urlToWork,
   				function(data){
   					d = data.replace("**YGKJ","").replace("YGKJ##", "");
   					d = $.parseJSON(d);
   					var buses = d["jsonr"]["data"]["buses"];
   					
   					var arr = [];
   					for(var i = 0; i < buses.length; i++){
   						var bus = buses[i];
   						if(bus.order <= 7){
   							arr.push(bus);
   						}
   					}
   					if(arr.length >= 3){
   						createMsg(arr.length);
   					}
   					if(d["jsonr"]["data"]["depDesc"] === ""){
   						$("#txt").text(buses[0]["distanceToSc"]);
   					}
   					else{
   						$("#txt").text(d["jsonr"]["data"]["depDesc"]);
   					}
   				})
   		}
   		
   		var timer;
   		$(function(){
   			
   			$("#lis").click(function(){
   				if(timer){
   					alert("已经启动");
   					return;
   				}
   				timer = setInterval(getBus, 2000);
   				});
   			
   			$("#clc").click(function(){
   				if ( watchId ) {
					plus.geolocation.clearWatch( watchId );
					watchId = null;
				}
   				if(timer){
   					clearInterval(timer);
   					timer = null;
   				}
   				
   			});
   			
   			$("#btn").click(function(){
   				plus.geolocation.getCurrentPosition( function(ip){
						$("#txt").text("位置:" + ip.addresses +",  经纬度:("+ ip.coords.latitude +"," + ip.coords.longitude + ")")
					}, function ( e ) {
						alert("定位失败");
					}, {geocode:true} );
					});
					
					
			
					
   		})