function ClearThisField(){
	if (document.frmSearch.st.value == " Search DevASP.Net Here")
		document.frmSearch.st.value= "";
}
function ClearThisField(textBox) {
  if (textBox.value == " Search DevASP.Net Here")
    textBox.value = "";
}
	
function ClearTextField(thisField){
	if (thisField.value == " Keyword Search ")
		thisField.value	= "";
	}
		
function ClearNLTextBox(ThisField){
	if (ThisField.value == "  Email Address  ")
		ThisField.value	= "";
	}


function SubmitOrderByForm()
	{
		document.OrderByForm.submit();
		return;
	}

function SubmitRatingForm(ThisField)
	{
		if (!ThisField.value =="")
			{
			//alert(ThisField.value);
			ThisField.form.submit();
			return;
			}
	}
	
	function RedirectToRating(ThisField) {
	  if (!ThisField.value == "") {
	    //alert(ThisField.value);
	    //'ThisField.form.submit();
	    //return;
	    window.location = "/net/search/Rating.asp?ID=" + ThisField.id + "&Rating=" + ThisField.value;
	    return;
	  }
	}
	
function OpenProductImageWindow(URL) 
	{
	var options;
	options = "toolbar=no,status=no,menubar=no,scrollbars=yes,resizable=yes,top=50,left=50,width=415,height=515";
	ProductImageWindow=window.open(URL,"ProductImageWindow", options);
	ProductImageWindow.focus();
	
	}


function BookMarkThisPage(Title, URL)
		{
	if (document.all)
		window.external.AddFavorite(URL,Title)
}