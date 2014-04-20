$().ready(function(){
		init_poll_results();
	});
function togglefreeform()
{
	$('input[@answer_id]')
		.each(function(index){
				if($(this).attr("checked"))
					$("#txt_"+$(this).attr("answer_id")).removeAttr("disabled");
				else{
				  $("#txt_"+$(this).attr("answer_id")).val();
				  $("#txt_"+$(this).attr("answer_id")).attr("disabled","true");
				  }
			});
					
}
function poll(poll_id)
{
	if(poll_id <= 0){
		alert(ERROR_BAD_POLL);
		return false;
	}
	var cookieVal = getCookie('pollcookie'+poll_id);	
    if(cookieVal == 'nocookie')
    {
        setCookie("pollcookie"+poll_id,"voted",180);
	    var html = "";
	    html += "{";
	    $('input[@answer_id]')
		    .each(function(index){
			    if($(this).attr("checked")){
				    html += '"'+$(this).attr("answer_id")+'"';
				    html += ':';
				    if($('#txt_'+$(this).attr("answer_id")).is("input")){
					    html += '"'+$('#txt_'+$(this).attr("answer_id")).val()+'"';		
				    }
				    else{ html += '""';}
				    html += ",";
			    }
		    });
	    html = html.substring(0,html.length-1);
	    if(html == ""){alert(ERROR_NO_POLL_SELECTED); return false;}
	    html += "}";
	    $.post("/services/setpoll/rnd="+Math.random(),
						    {poll_id:poll_id,
						     answer_ids:html},
						     function(data){
						          alert(POLL_SUCCESS);
    						          clear_poll();
						          showresults(poll_id);
						     });
    }
    else
    {   
        alert(POLL_RETRY);     
    }
    
	
}
function clear_poll()
{
	 $('input[@answer_id]')
                .each(function(index){
			       $(this).removeAttr("checked");
                               $("#txt_"+$(this).attr("answer_id")).attr("disabled","true");   
                               $("#txt_"+$(this).attr("answer_id")).val("");   
                     });
}
function init_poll_results()
{        $(document.body).prepend('<div class="jqmWindow box" style="left:50%;width:400px;height:400px;overflow:auto" id="poll_res">'+ '<div class="boxHeader"><a href="#" alt="close" class="jqmClose">' + "[X]" + '<b></a>&nbsp;&nbsp;'+ POLL_RESULTS + '</b></div>'  
                + '<div align="center" class="boxBody">'
                + '<div id="poll_result"><img src="/media/images/progressbar.gif"></div><br>'
                + '<br>'
                + '</div>'        
                + '</div>'
             );  
        $('#poll_res').jqm({
                overlay:10,
                modal: true,
                onHide: function(hash){
                        hash.w.fadeOut('1000',function(){ hash.o.remove(); });
                }
        });
}
function showresults(id)
{
	$("#poll_res").jqm().jqmShow();
	var urlparts = window.location.pathname.split('/');
        var lang_code = urlparts[1];
	$.post("/"+lang_code+"/services/getpollresults/rnd="+Math.random(),{poll_id:id},
				function(data){
					$('#poll_result').html(data);;
				});
}


function setCookie(c_name,value,expiredays)
{
    var exdate=new Date();
    exdate.setDate(exdate.getDate()+expiredays);
    document.cookie=c_name+ "=" +escape(value)+ ((expiredays==null) ? "" : ";expires="+exdate.toGMTString());
}

function getCookie(c_name)
{
    if (document.cookie.length>0)
    {
        c_start=document.cookie.indexOf(c_name + "=");
        if (c_start!=-1)
        { 
                    c_start=c_start + c_name.length+1;
                    c_end=document.cookie.indexOf(";",c_start);
                    if (c_end==-1)
                    {
                                c_end=document.cookie.length;
                    }
                    return unescape(document.cookie.substring(c_start,c_end));
        }
        else
        {
                    return "nocookie";
        }
    }
    return "nocookie";
}
