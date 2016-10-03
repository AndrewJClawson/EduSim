AjaxCall = function(url, data, div, completeCallback, completeCallbackDataRequired) {
	var completeCallbackData;
	$.ajax({
		type:'POST',
		url: url,
		cache:false,
		data:data,
		complete: function() {
			if (completeCallback && completeCallbackDataRequired) {
				completeCallback(completeCallbackData);
			}
			else if {
				completeCallback();
			}
		}
		error: alert("Error");
	});
}