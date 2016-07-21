		function changeImage(text){
    		$("#GA_img").attr('src','img/'+text)
    		render()
    	}
    	var pos
		var canvas
		var img
		var ctx
		var interval=500
		var draw=false

   		window.onload = function() {
			pos = [];
			canvas = $('#GA_canvas')[0];
			img = $('#GA_img')[0];
			ctx = canvas.getContext("2d");

			canvas.width = img.width;
			canvas.height = img.height;

			ctx.fillStyle="#ffffff"
			setInterval(render, interval);
			// render()
		};
		function render() {
			from_date=$('#fromDate')[0].value
			to_date=$('#toDate')[0].value
			step=$('#speed').val

			if(draw){

				$.ajax({
  				type: "GET",
	  			url: "http://127.0.0.1:1325/testReq.ashx?req=123123123",
  				data: "from="+from_date+"&to="+to_date,
  				dataType: 'json',
  				success: function(json){
  					// obj = JSON.parse(msg);
	    			console.log( "Прибыли данные: " +  json);
  				}
				});

				var startx=Math.random()*canvas.width
				var starty=Math.random()*canvas.height
			}
		    ctx.drawImage(img, 0, 0);
		    ctx.fillRect(startx,starty,10,10)

		    ctx.stroke()
		}
