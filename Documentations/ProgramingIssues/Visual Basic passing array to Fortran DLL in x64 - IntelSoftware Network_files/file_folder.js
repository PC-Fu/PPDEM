$(function(){
	init_file_upload();
	init_file_download();
	maketrackdownload();
});
function maketrackdownload() {
        $("a[href*='/file/'][href]").each(function(){
                if($(this).attr('href').indexOf('target=') <= 0){
					if(!($(this).attr('target'))){
						if($(this).attr('onclick') == null) {
									var a = $(this).attr('href');
									$(this).bind("click",function(e) {
											ndownload(a);
									});
									$(this).attr('href','javascript:void(0)');
							}
					}
                }
        });
}
//var fld_id = 0;
function printfolder()
{
	  $('#loading').show();
	  var urlparts = window.location.pathname.split('/');
	  var lang_code = urlparts[1];
	  $.post('/'+lang_code+'/services/printfolder/rnd='+Math.random(),
					function(data)  
                                      	{ 
                                               $('#file_folder_display').html(data);
                                     	});	
}
function getfiles(folder_id){
	fld_id = folder_id;
	$('#loading').show();
	var urlparts = window.location.pathname.split('/');
	var lang_code = urlparts[1];
	$.post('/'+lang_code+'/services/printfiles/rnd='+Math.random(),
					  {fid:folder_id},
					  	function(data){
						 $('#file_folder_display').html(data);
						 $('#loading').hide();
					  });
}
function getfiletype(name,val,folder_id)
{
	$('#file_type_title').html(name);
	$('#hdn_file_type').val(val);
	getfolder(folder_id,val);
	
}
	function fileupload(folder_id)
	{
   	
	  if($('#fileToUpload').val() != ""){
 	   $('#loading').show();                                   
                         $.ajaxFileUpload({
                                url:'/services/file/upload.php?fid='+folder_id,
                                secureuri:false,
                                fileElementId:'fileToUpload',
                                dataType: 'json',
                                success:function (data, status)
                                {
					if(parseInt(data) > 0) {
						show_file(parseInt(data),folder_id);			
					}
					else {get_files(folder_id);}
                                },
                                error:function (data, status)
                                {
					if(parseInt(data) > 0) {
						show_file(parseInt(data),folder_id);			
					}
					else {get_files(folder_id);}
                                }
                                });
                    return false;
	}
	else{
		alert(ERROR_BAD_FILE);
	}
     }
	function addfile(file_name,type,mime,path,id)
	{
		if(type == 'INLINE'){
		}
		else{
			$('#'+file_attach).append("<span id='attach_"+id+"'><a href='"+path+"'><img src='/media/images/file.png' height=40px width=40px /> "+file_name+" </a><a href='javascript:removeme("+id+");' >"+FILE_CLOSE+"</a><br /></span>");
		}
	}

	function init_file_upload(){
		$(document.body).prepend('<div class="jqmWindow box" style="left:30%;top:5%;z-index:9999999;width:772px" id="media_uploads">'+ '<div class="boxHeader" style="height:20px;width:740px;background-color:#EAF3FA;" align="right"><span style="margin-right:600px">'+FILE_ADD_MEDIA+'</span> <a href="#" class="jqmClose" style="color:#0861AD"><b>'+FILE_CLOSE+'</b></a></div>'
                + '<div align="center" class="boxBody">'
                + '<div id="file_data" align="left"><img src="/media/images/progressbar.gif"></div><br>'
                + '<br>'
                + '</div>'
                + '</div>'
                );
	        $('#media_uploads').jqm({
                	overlay:10,
                	modal: true,
                	onHide: function(hash){
                        	hash.w.fadeOut('1000',function(){ hash.o.remove(); });
                	}
        	});
	}
	function init_file_download(){
		var path = "";
		$('.filedownload').each(function(){
			if(!$(this).attr('file_path')){
				$(this).attr("file_path",$(this).attr("href"));
				$(this).attr("href","javascript:void(0); ");
			}
		});
		$(document.body).prepend('<div class="jqmWindow box" style="width:220px;left:50%;z-index:9999999" id="media_downloads">'+ '<div class="boxHeader" style="width:203px;background-color:#EAF3FA;"><a href="#" class="jqmClose" style="color:#0861AD"><b>[X]</b></a>  '+DOWNLOAD_FILE+'</div>'
                + '<div align="center" class="boxBody">'
                + '<div id="download_data"><img src="/media/images/progressbar.gif"></div><br>'
                + '<br>'
                + '</div>'
                + '</div>'
                );
	        $('#media_downloads').jqm({
                	overlay:10,
                	modal: true,
                	onHide: function(hash){
                        	hash.w.fadeOut('1000',function(){ hash.o.remove(); });
                	}
        	});
	}

	function removeme(id){
		$('#attach_'+id).remove();
		input_attach();
	}
	function deletefile(id){
		var urlparts = window.location.pathname.split('/');
	var lang_code = urlparts[1];
		if(confirm(FILE_DELETE_CONFIRM) == true){
		  $.post('/'+lang_code+'/services/deletefile/rnd='+Math.random(),{fid:id},
 		  function(data)  
                     { 
			getfiles(fld_id);
                      });	
		}
		
	}
	var marker;
        function show_file_upload(){
		if(typeof tinyMCE != 'undefined'){
			var content  = tinyMCE.getInstanceById(file_inline);
        	        marker = content.selection.getBookmark();
		}
		$("#media_uploads").jqm().jqmShow();
		$('#file_data').html("<img src='/media/images/progressbar.gif' />");		
		get_folders();
	}
        function show_file_download(download_id,email_req,path){
		if (typeof(path)=='undefined'){
			path = "";
		}
		$("#media_downloads").jqm().jqmShow();
		$('#download_data').html("<img src='/media/images/progressbar.gif' />");		
		var html = "";
		$.getJSON("/services/getdownloads/"+download_id,function(data){
			if((data) && (data.length == 1)){
				data = data[0];
				html += "<table cellpadding=0 cellspacing=0>";
				html += "<tr>";
				html += "<td>"+FILE_EMAIL;
				if(email_req){
					html += "*";
				}
				html += "</td><td>&nbsp;</td>";
				html += "<td><input maxlength='255' type='text' id='file_download_email_"+download_id+"' /></td>";
				html += "</tr>";
				html += "</table><br />";
				html += "<input type='button' class='button' value='"+DOWNLOAD_ACCEPT+"' onclick=set_download('"+email_req+"',"+download_id+",'"+path+"'); /><br /><br />";
				html += "<div style='padding:1px' align='left'><a target='blank' href='"+data['download_terms_use']+"'>"+DOWNLOAD_TERMS_COND+"</a></div>";
				html += "<div style='padding:1px' align='left'><a target='blank' href='"+data['download_permissions']+"'>"+DOWNLOAD_TERMS_USE+"</a></div>";
				html += "<div style='padding:1px' align='left'>"+DOWNLOAD_SUBMIT_EMAIL+"</div>";
				$('#download_data').html(html);
			}
		});
	}
	function set_download(email_required,download_id,path){
		if ((typeof(path)=='undefined') || (path == "")){
			path = $('#free_download_'+download_id).attr("file_path");
		}
		var email = $('#file_download_email_'+download_id).val();
		var download_path = location.protocol+"//"+location.host+location.pathname;
		if(email_required == "true"){
			if(email == ""){
				alert(ERROR_BAD_EMAIL);
				return false;
			}	
		}
		act_download(download_id,path,email,download_path);
	}
	function act_download(download_id,path,email,download_path){
		var urlparts = window.location.pathname.split('/');
	var lang_code = urlparts[1];
		$.post("/"+lang_code+"/services/setdownloadsemail/rnd="+Math.random(),{ download_id:download_id,
									  file_path:path,
									  email:email,
									  url:download_path },
			function(data){
				$('#media_downloads').jqmHide();
				track_download(path,email,data);
				if(navigator.appName == "Microsoft Internet Explorer"){
		                        TimedPopup("/media/js/ie_file.php?f="+path);        
                		}
		                else{            
                		        window.location = path;
                		}
			});
	}

	var can_download = false;
	function show_file(file_id,folder_id){
		var html = "";
		var urlparts = window.location.pathname.split('/');
	var lang_code = urlparts[1];
		$.post("/"+lang_code+"/services/getfiledetails/rnd="+Math.random(),{file_id:file_id},
			function(data){
				var jdata = eval('('+data+')');
				if(jdata){
					html += "<div style='width:675px;height:20px;padding-right:10px' align='right'>";
					html += "<a href='javascript:get_files("+folder_id+");'>"+FILE_BACK_FOLDER+"</a></div>";
					html += "<table style='padding:5px;height:90px;background-color:#EAF3FA' width='100%' cellpadding=0px cellspacing=0px>";
					html += "<tr>";
					html += "<td style='width:110px;height:100px' align='left'>";
					if((jdata['file'][0]['file_type'] == "IMAGE") && (jdata['file'][0]['file_is_cropped'] == 'YES')){
						html += "<img src='/file/"+jdata['file'][0]['file_id']+"/m' />"; 
					}
					else if((jdata['file'][0]['file_type'] == 'IMAGE') && (jdata['file'][0]['file_is_cropped'] == "NO")){
						html += "<img src='/file/"+jdata['file'][0]['file_id']+"' height='90px' width='90px' />";
					}
					else{
						html += "<div class='file_binary' style='height:90px;width:90px'></div>";
					}
					html += "</td>";
					html += "<td style='width:580px;height:90px' align='left'><b>";
					html += jdata['file'][0]['file_name'] + "<br /><br />";
				 	html += jdata['file'][0]['file_mime_type'] + "<br /><br />";
					html += jdata['file'][0]['created_dt'];
					html += "</b></td>";
					html += "</tr></table>";
					html += "<div id='file_details'>";
					html += "<table cellpadding='0' cellspacing='0'>";
					html += "<tr>";
					html += "<td><b>"+FILE_TITLE+"</b></td>";
					html += "<td>&nbsp;</td>";
					html += "<td><input type='text' id='file_title' style='width:450px' value='"+jdata['file'][0]['file_name']+"' /></td>";
					html += "</tr>";
					html += "<tr>";
					html += "<td><b>"+FILE_CAPTION+"</b></td>";
					html += "<td>&nbsp;</td>";
					html += "<td><input type='text' id='file_caption' style='width:450px' value='"+jdata['file'][0]['file_name']+"' /><br />";
					html += FILE_ALT_TEXT+"</td></tr>";
					html += "<td><b>"+FILE_LINK_URL+"</b></td>";
					html += "<td>&nbsp;</td>";
					html += "<td><input readonly type='text' id='file_url' style='width:450px' value='"+location.protocol+"//"+location.host+"/file/"+jdata['file'][0]['file_id']+"' /></td></tr>";
					if(jdata['file'][0]['file_type'] == "IMAGE"){
						html += "<tr><td><b>"+FILE_SIZE+"</b></td>";
						html += "<td>&nbsp;</td>";
						html += "<td><select style='width:200px' id='file_size'>";
						html += "<option value=''>"+FILE_SIZE_ORG+"</option>";
						if(jdata['image_size']){
							html += "<option value='s'>"+FILE_SIZE_SMALL+jdata['image_size']['small']+"</option>";
							html += "<option value='m'>"+FILE_SIZE_MEDIUM+jdata['image_size']['medium']+"</option>";
							html += "<option value='l'>"+FILE_SIZE_LARGE+jdata['image_size']['large']+"</option>";
							html += "<option value='x'>"+FILE_SIZE_X_LARGE+jdata['image_size']['xlarge']+"</option>";
						}
						html += "</select>";
						html += "</td></tr>"; 
					}
					html += "<tr>";
					html += "<tr>";
					var html_hdn = "";
					if(jdata['download']){
						can_download = true;
						html += "<td><b>"+FILE_DOWNLOAD_TYPE+"</b></td>";
						html += "<td>&nbsp;</td>";
						html += "<td>";
						
						html += "<select id='sel_download' style='width:200px'>";
						html += "<option value='0'>"+FILE_DOWNLOAD_OPTION_NONE+"</option>";
						for(var i=0;i<jdata['download'].length;i++){
							html += "<option value='"+jdata['download'][i]['download_id']+"'>";
							html += jdata['download'][i]['download_title'];
							html += "</option>";
							/*html_hdn += "<input type='hidden' id='hdn_terms_"+jdata['download'][i]['download_id']+"'";
							html_hdn += " value='"+jdata['download'][i]['download_permissions']+"' />";
							html_hdn += "<input type='hidden' id='hdn_use_"+jdata['download'][i]['download_id']+"'";
							html_hdn += " value='"+jdata['download'][i]['download_terms_use']+"' />";
							html_hdn += "<input type='hidden' id='hdn_email_"+jdata['download'][i]['download_id']+"'";
							html_hdn += " value='"+jdata['download'][i]['require_email']+"' />";*/
						}
						html += "</select>";
						html += html_hdn;
						html += "</td>";
						html += "<tr><td><b>"+FILE_DOWNLOAD_REQ_EMAIL+"</b></td>";
						html += "<td>&nbsp;</td>";
						html += "<td><input type='checkbox' id='chk_require_email' /></tr>";
					}
					html += "</tr>";
					html += "</table><br /><input class='button' type='button' onclick=add_file_editor("+jdata['file'][0]['file_id']+",'"+jdata['file'][0]['file_type']+"'); value='"+FILE_BTN_ADD_EDITOR+"' />";
					if(typeof $('#hdn_file_attachments') != 'undefined'){
						html += " <input type='button' class='button' onclick='add_file_attachment("+jdata['file'][0]['file_id']+")' value='"+FILE_BTN_ADD_ATTACH+"' />";
					}
					$('#file_data').html(html);
					}
			});
	}
	function add_file_attachment(id){
		if(!check_attach(id)){
			var path = $('#file_url').val();
			var file_name = $('#file_title').val();
			var file_path = get_path_download(path,file_name);
			$('#'+file_attach).append("<span id='attach_"+id+"' file_id='"+id+"' class='file_attachment'>"+file_path+"<a href='javascript:removeme("+id+");' >[X]</a></span>&nbsp;");
			input_attach();
			$('#media_uploads').jqmHide();  
			$('#file_attachment_text').show();
		}
		else{
			alert(ERROR_FILE_ATTACH_EXISTS);
		}
	}
	function check_attach(id){
		var attach_array = $('#hdn_file_attachments').val().split(',');
		for(var i=0;i<attach_array.length;i++){
			if(id == attach_array[i]){
				return true;
			}
		}
		return false;
	}
	function input_attach(){
		var html = "";
		$('.file_attachment').each(function(){
			html += $(this).attr("file_id")+ ",";	
		});
		if(html == ""){
			$('#file_attachment_text').hide();
		}
		else{
			$('#file_attachment_text').show();
		}
		$('#hdn_file_attachments').val(html);
	}
	function get_path_download(path,file_name){
		var file_path = "";
		file_path += "<a ";
		if(can_download){
			var sel_box = document.getElementById("sel_download");
			var sel_val = sel_box.options[sel_box.selectedIndex].value;
			var require_email = false;
			if($('#chk_require_email').attr("checked")){require_email = true;}
			if(sel_val > 0){
				file_path += "href='"+path+"' class='filedownload' title='download_"+sel_val+"' id='free_download_"+sel_val+"' onclick=show_file_download("+sel_val+","+require_email+",'"+path+"') ";
			}
			else{
				file_path += "href='javascript:void(0)' onclick=ndownload('"+path+"') ";
			}
		}
		else{
			file_path += "href='javascript:void(0)' onclick=ndownload('"+path+"') ";
		}
		file_path += " >"+file_name+"</a>";
		return file_path;
	}
	function ndownload(path){
		act_download(-1,path,"no email download",thisURL);
	} 
	function track_download(url,email,file_name){
		var ref = document.referrer;
		if(url.length > 96){    
		        url = url.substring(0,96);
		}  
		if(ref.length > 96){    
		        ref = ref.substring(0,96);
		}  
                var wa_customStuff =
                "wa_custom48=" + ref
                + "&wa_custom08=" + email
                + "&wa_custom09=" + url
                + "&wa_eCustom22=" + email
                + "&wa_events=se_cust22";
                waTrackAsLink(file_name,"d", wa_customStuff,"N");
        }
	function add_file_editor(id,file_type){
                var path = $('#file_url').val();
                var file_name = $('#file_title').val();
                var caption = $('#file_caption').val();
                var size = document.getElementById("file_size");
                var text = "";
                if(size){
                        var file_size = size.options[size.selectedIndex].value;
                        if(file_size != ""){
                                path += "/"+file_size;
                        }
                }
                if(typeof tinyMCE != 'undefined'){        
                        var content  = tinyMCE.getInstanceById(file_inline);        
                        //if (content.isIE){        
                        content.selection.moveToBookmark(marker);        
                        //}        
                        if(file_type == "IMAGE"){
                                text = "<img src='"+path+"' title='"+file_name+"' alt='"+escape(caption)+"' />";                        }    
                        else{
				text = get_path_download(path,file_name);
                        }       content.execCommand('mceInsertContent', false, text);                                                                            
			$('#media_uploads').jqmHide();
                }         
                else{        
                        alert(ERROR_EDITOR_PROBLEM);        
                }
        }
	function get_files(folder_id){
		
		var urlparts = window.location.pathname.split('/');
	var lang_code = urlparts[1];
		$.post("/"+lang_code+"/services/getfiles/rnd="+Math.random(),{folder_id:folder_id},function(data){
			display_files(data,folder_id);
		});
	}
	function display_folders(data){
		var html = "";
		html += "<div style='width:675px;height:25px;'>";
		html += "<div align='right' style='width:475px;float:right;height:25px;'><input type='text' id='search_folder' /> <input type='button' class='button' value='"+FILE_SEARCH_FOLDER+"' onclick='search_folders()' /></div>";
		html += "<div align='left' style='float:left;width:200px;height:25px;'><span class='h2_nob'><h1>"+FILE_ALL_FOLDER+"</h1></span></div>";
		html += "</div>";
		html += "<div class='seperator'></div>";
		html += "<table id='folder_create' style='background-color:#EAF3FA;height:50px;padding:5px' width='100%' cellspacing='0' cellpadding='0'>"; 
                html += "<tr><td width='50%' style='background-color:#EAF3FA;'><input type='text' id='folder_name' /><input class='button-secondary' id='btn_create_folder' type='button' value='"+FILE_CREATE_FOLDER+"' style='padding:4px;vertical-align:top' onclick=create_folder(0,'name'); /> <input type='button' onclick='delete_folder();' value='"+FILE_DELETE+"' class='button-secondary' style='padding:4px;vertical-align:top' />\n<img src='/media/images/progressbar.gif' id='loading' style='display:none' /></td>";      
                html += "<td width='50%' style='padding-right:5px;background-color:#EAF3FA;height:60px' align='right'><div id='folder_paginate' style='padding-top:5px'></div></td>";
                html += "</tr></table>";
		if((data != "") && (data != "\n")){
			var jdata = eval('('+data+')');
			html += "<table class='widefat folder_table' cellspacing='0' cellpadding='0'>";
			html += "<thead><tr><th class='colheader' style='width: 20px;'></th><th class='colheader' align='left'>"+FILE_FOLDER_TITLE+"</th><th class='colheader' style='width: 20px;'>"+FILE_FILES+"</th><th class='colheader' align='left'>"+FILE_CREATE_DATE+"</th><th class='colheader' align='left'>"+FILE_ACTION+"</th></tr></thead>";
			html += "<tbody>";
			for(var i=0;i<jdata.length;i++){
				html += "<tr>";
				html += "<td align='left' width='5%' style='width: 20px;' class='widefat'><input type='checkbox' class='ckh_folder' folder_id='"+jdata[i]['folder_id']+"' /></td>";
				html += "<td align='left' class='widefat'><span id='span_folder_"+jdata[i]['folder_id']+"'><a href='javascript:get_files("+jdata[i]['folder_id']+")' ><b>"+jdata[i]['folder_title']+"</a></span></b></td>";
				html += "<td align='left' class='widefat' width='5%' style='width: 20px;'>"+jdata[i]['file_count']+"</td>";
				html += "<td class='widefat' align='left'><b>"+jdata[i]['created_dt']+"</b></td>";
				html += "<td class='widefat' align='left'><b><span id='span_edit_"+jdata[i]['folder_id']+"'><a href='javascript:edit_folder("+jdata[i]['folder_id']+")'>"+FILE_EDIT+"</a> <a href='javascript:delete_folder("+jdata[i]['folder_id']+")' >"+FILE_DELETE+"</a></span></td>";
				html += "<input type='hidden' value='"+jdata[i]['folder_title']+"' id='hdn_folder_"+jdata[i]['folder_id']+"' />";
				html += "</tr>";
			}
			html += "</tbody>";
			html += "</table>";
		}
		$('#file_data').html(html);
		$('tbody tr:even').addClass("even");
		paginate("folder_paginate","folder_table",10);
	}

	function display_files(data,folder_id){
		var html = "";
		html += "<div style='width:675px;height:20px;padding-right:10px' align='right'>";
		html += "<a href='javascript:get_folders();'>"+FILE_BACK_FOLDER+"</a></div>";
		html += "<div style='width:675px;height:25px;'>";
		html += "<div align='right' style='width:475px;float:right;height:25px;'><input type='text' id='search_folder' /> <input class='button' type='button' value='"+FILE_SEARCH_FOLDER+"' onclick='search_folders()' /></div>";
		html += "<div align='left' style='float:left;width:200px;height:25px;'><span class='h2_nob'><h1>"+FILE_FILES+"</h1></span></div>";
		html += "</div>";
		html += "<div class='seperator'></div>";
		html += "<table id='file_uploader' cellpadding='0px' style='background-color:#EAF3FA;height:50px;padding:5px' cellspacing='0px' width='100%'>";
		html += "<tr><td style='background-color:#EAF3FA;'><input type='file' id='fileToUpload' name='fileToUpload' style='height:20px;' class='button-secondary'/> <input class='button-secondary' type='button' value='"+FILE_UPLOAD+"' onclick='fileupload("+folder_id+")' /> <input type='button' class='button-secondary' onclick='delete_files("+folder_id+")' value='"+FILE_DELETE+"'><br /><img src='/media/images/progressbar.gif' id='loading' style='display:none' /></td>";
		html += "<td align='right' style='padding-right:5px;background-color:#EAF3FA;'><div style='padding-top:5px' id='file_paginate'></div></td></tr></table>";
		var jdata = eval('('+data+')');
		if(jdata){
			html += "<table class='widefat file_table' cellspacing='0' cellpadding='0'>";
			html += "<thead><tr><th class='colheader' style='width: 20px;'></th><th class='colheader' style='width: 50px;'></th><th align='left'>"+FILE_FOLDER_TITLE+"</th><th align='left'>"+FILE_CREATE_DATE+"</th><th align='left'>"+FILE_ACTION+"</th></tr></thead>";
			html += "<tbody>";
			for(var i=0;i<jdata.length;i++){
				html += "<tr>";
				html += "<td class='widefat'><input type='checkbox' file_id='"+jdata[i]['file_id']+"' class='chk_file' /></td>";
				html += "<td align='left' class='widefat'>";
				if((jdata[i]['file_type'] == 'IMAGE') && (jdata[i]['file_is_cropped'] == "YES")){
					html += "<img src='/file/"+jdata[i]['file_id']+"/s' />";
				}
				else if((jdata[i]['file_type'] == 'IMAGE') && (jdata[i]['file_is_cropped'] == "NO")){
					html += "<img src='/file/"+jdata[i]['file_id']+"' height='60px' width='60px' />";
				}
				else{
					html += "<div class='file_binary'></div>";
				}
				html += "</td>";
				html += "<td class='widefat' align='left'><b><span id='span_file_"+jdata[i]['file_id']+"'><a href='javascript:show_file("+jdata[i]['file_id']+","+folder_id+");' >"+jdata[i]['file_name']+"</a></span></b></td>";
				html += "<td class='widefat'><b>"+jdata[i]['created_dt']+"</b></td>";
				html += "<td class='widefat'><b><span id='span_file_edit_"+jdata[i]['file_id']+"'><a href='javascript:edit_file("+jdata[i]['file_id']+","+folder_id+")'>"+FILE_EDIT+"</a> <a href='javascript:delete_files("+folder_id+","+jdata[i]['file_id']+")' >"+FILE_DELETE+"</a></span></b></td>";
				html += "<input type='hidden' value='"+jdata[i]['file_name']+"' id='hdn_file_"+jdata[i]['file_id']+"' />";
				html += "</tr>";
			}
			html += "</tbody>";
			html += "</table>";
		}
		$('#file_data').html(html);
		$('tbody tr:even').addClass("even");
		paginate("file_paginate","file_table",5);

	}
	function create_folder(folder_id,type)
	{
		if($('#folder_'+type).val() != ""){
			$('#loading').show();
			var urlparts = window.location.pathname.split('/');
			var lang_code = urlparts[1];
			$.post('/'+lang_code+'/services/createfolder/rnd='+Math.random(),{folder_title:$('#folder_'+type).val(),
												      folder_id:folder_id,
										      	    folder_status:'ACTIVE'
   					      						    },function(data)
						  					      {
													if(type == "name") {
													get_folders();
													}
													else {
													window.location.reload();
													}
													
											      });
		}
		else{
			alert(ERROR_BAD_FOLDER);
		}
	}
	function get_folders(){
		var urlparts = window.location.pathname.split('/');
		var lang_code = urlparts[1];
		$.post("/"+lang_code+"/services/getfolders/rnd="+Math.random(),function(data){
			display_folders(data);
		});
	}
	var fld_id = -1;
	function edit_folder(folder_id){
		if(fld_id > 0){
			$('#span_edit_'+fld_id).html("<a href='javascript:edit_folder("+fld_id+");'>"+BIO_EDIT+"</a>");
			$('#span_folder_'+fld_id).html("<b><a href='javascript:get_files("+fld_id+");>"+$('#hdn_folder_'+fld_id).val()+"</a></b>");
		}
		fld_id = folder_id;
		$('#span_edit_'+folder_id).html("<a href=javascript:create_folder("+folder_id+",'edit'); >"+FILE_UPDATE+"</a> <a href='javascript:get_folders()'>"+SETTINGS_CANCEL+"</a>");
		var folder_name = $('#hdn_folder_'+folder_id).val();
		$('#span_folder_'+folder_id).html("<input type='text' id='folder_edit' value='"+folder_name+"' />");
	}
	var f_id = -1;
	var fld_f_id = -1;
	function edit_file(file_id,folder_id){
		if(f_id > 0){
			$('#span_file_edit_'+f_id).html("<a href='javascript:edit_file("+f_id+","+fld_f_id+");'>"+BIO_EDIT+"</a>");
			$('#span_file_'+fld_id).html("<b><a href='javascript:show_file("+f_id+");>"+$('#hdn_file_'+f_id).val()+"</a></b>");
		}
		f_id = file_id;
		fld_f_id = folder_id;
		$('#span_file_edit_'+file_id).html("<a href=javascript:rename_file("+file_id+","+folder_id+",'edit'); >"+FILE_RENAME+"</a> <a href='javascript:get_files("+folder_id+")'>"+SETTINGS_CANCEL+"</a>");
		var file_name = $('#hdn_file_'+file_id).val();
		$('#span_file_'+file_id).html("<input type='text' id='file_edit' value='"+file_name+"' />");
	}
	function rename_file(file_id,folder_id){
		if($('#file_edit').val() != ""){
			var urlparts = window.location.pathname.split('/');
			var lang_code = urlparts[1];
			$.post("/"+lang_code+"/services/renamefile/rnd="+Math.random(),{file_id:file_id,file_name:$('#file_edit').val()},function(){
					get_files(folder_id);
			});
		}
		else{
			alert(ERROR_BAD_FILE_NAME);
		}
	}
	function delete_folder(folder_id){
		var folder_ids = "";
		var urlparts = window.location.pathname.split('/');
	 	var lang_code = urlparts[1];
		if(confirm(FILE_FOLDER_DELETE_CONFIRM) == true){
			$('#loading').show();
			if(folder_id==undefined){
				$(".ckh_folder").each(function(){
					if($(this).attr("checked")){
						folder_ids += $(this).attr("folder_id") + "|";	
					}
				});
			}
			else{
				folder_ids = folder_id;
			}
			$.post("/"+lang_code+"/services/deletefolders/rnd="+Math.random(),{folder_ids:folder_ids},function(){
				get_folders();
			});
		}
	}
	function delete_files(folder_id,file_id){
		var file_ids = "";
		
		var urlparts = window.location.pathname.split('/');
	var lang_code = urlparts[1];
		if(confirm(FILE_DELETE_CONFIRM) == true){
			$('#loading').show();
			if(file_id == undefined){
				$(".chk_file").each(function(){
					if($(this).attr("checked")){
						file_ids += $(this).attr("file_id") + "|";	
					}
				});
			}
			else{
				file_ids = file_id;
			}
			$.post("/"+lang_code+"/services/deletefiles/rnd="+Math.random(),{file_ids:file_ids},function(){
				get_files(folder_id);
			});
		}
	}
	function search_folders(){
		var urlparts = window.location.pathname.split('/');
		var lang_code = urlparts[1];
		$.post("/"+lang_code+"/services/searchfolders/rnd="+Math.random(),{folder_title:$('#search_folder').val()},function(data){
                        display_folders(data);
                });
	}
	function paginate(page_id,table_class,numberofpages){
		$('table.'+table_class ).each(function(){
			var current_page = 0;
			var $table = $(this);
			$table.bind('repaginate',function(){
				$table.find('tbody tr').show()
				      .slice(0, current_page * numberofpages)
					   .hide()
				      .end()
				      .slice((current_page + 1) * numberofpages)
					   .hide()
				      .end()
			});
			var numrows  = $table.find('tbody tr').length;
			var numpages = Math.ceil(numrows/numberofpages);
			var $pager = $('#'+page_id);
			for(var page = 0;page < numpages; page++){
				$('<span class="page-numbers" style="border:1px solid silver;" align="right"><a href="#">'+ (page + 1) + '</a></span>')
				.bind('click', {'newPage': page},function(event){
					current_page = event.data['newPage'];
					$table.trigger('repaginate');
					$(this).addClass('active current').siblings().removeClass('active current');
				})
			      .appendTo($pager).addClass('clickable');
			}
			$pager.find('span.page-numbers:first').addClass('active current');
			//$pager.insertBefore($table);
			$table.trigger('repaginate');
		});
	}


// IE FIX SHOULD BE REMOVED


var TimeOut = 30;    // Initial time to Close window after __ number of seconds?
var TimeRemain = 0;  // Remaining time to Close window after __ number of seconds?
var RefreshRate = 2; // Check to close window every __ number of seconds?
var ChildWin = null;
function TimedPopup(url)
{
 windowprops = "left=0,top=0,width=320,height=130,resizable=yes"; // May be adjusted according to your needs
 if (ChildWin)
     return false;
 ChildWin = window.open(url, "ChildWin", windowprops);
 ResetTimer();
 if (TimeOut && RefreshRate)
    setTimeout("CheckClose();",RefreshRate * 1000);
}
function ResetTimer()
{
 TimeRemain = TimeOut;
}
function CheckClose()
{
 TimeRemain -= (RefreshRate);
 if (TimeRemain > 0)
    {
    if (ChildWin && ChildWin.closed)
       {
	ChildWin = null;
       }
    else
    if (ChildWin)
       {
	setTimeout("CheckClose();",RefreshRate * 1000);
       }
    }
 else
 if (ChildWin)
    {
     if (ChildWin.closed)
	 ChildWin = null;
     else
	{
         ChildWin.close();
	 ChildWin = null;
        }
    }
}
