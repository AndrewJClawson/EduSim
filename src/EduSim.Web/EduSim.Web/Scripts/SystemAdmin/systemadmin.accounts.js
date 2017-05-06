var systemadmin_accounts = (function(){

	function onAppearing() {

	}

	function loadAccountDetails() {
		var id = $("#SelectedAccountId");
		var postData = { accountId: id };
		$.ajax({
			contentType: "application/json; charset=utf-8",
			type: "POST",
			url: "/Account/GetDetails",
			data: postData,
			success: function(result) {
				if (result.Success) {
					$("#AccountName").val(result.Account.Name);
				}
				else {
					alert("failure loading details");
				}
			}

		});
	}

	$
	$(document).ready(function(){
		$("#new-account-button").click(function(){
			alert("Feature coming soon!");
		});

		$("#SelectedAccountId").on("change", loadAccountDetails);
	});
	return {
		onAppearing: onAppearing,
		loadDetails: loadAccountDetails
	}
})()
