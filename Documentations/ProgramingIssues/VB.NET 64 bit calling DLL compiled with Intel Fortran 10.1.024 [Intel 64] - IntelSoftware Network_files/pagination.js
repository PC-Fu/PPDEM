function shownavbar(url,form_name)
{   var currpage = $('#currpage').val();
  var totpages = $('#totpages').val();
  var linkfirstprev = '';
  if (currpage > 10)
    linkfirstprev += '<a href="javascript:nav(\'i--\','+ url +','+form_name+')"><< '+PAGINATION_FIRST+'</a>&nbsp;&nbsp;';
  linkfirstprev += '<a href="javascript:nav(\'i-\','+ url +','+form_name+')" class="prev page-numbers">< '+PAGINATION_PREV+'</a>&nbsp;&nbsp;';
  unlinkfirstprev = PAGINATION_FIRST+'&nbsp;';
  unlinkfirstprev += PAGINATION_PREV+'&nbsp;';
  linknextlast = '&nbsp;<a href="javascript:nav(\'i+\','+ url +','+form_name+')" class="next page-numbers">'+PAGINATION_NEXT+' ></a>&nbsp;&nbsp;';
  if (currpage < (Math.ceil(totpages/10)*10-10)+1)    linknextlast += '<a href="javascript:nav(\'i++\','+ url +','+form_name+')">'+PAGINATION_LAST+' >></a>';
  unlinknextlast = PAGINATION_NEXT+'&nbsp;';
  unlinknextlast += PAGINATION_LAST+'&nbsp;';
  if (currpage > 1)    $('#firstprev').html(linkfirstprev);
  else    $('#firstprev').html('');
  if (currpage == totpages || totpages == 0)    $('#nextlast').html('');                
  else    $('#nextlast').html(linknextlast);

  var minpage = 1;
  if (totpages > 10 && (Math.ceil(totpages/10)*10 != Math.floor(totpages/10)*10)) {
    if (currpage > Math.floor(totpages/10)*10) {                                   
      if ((totpages - currpage) < 9)            
        minpage = totpages - 9;
    }                          
    else
       minpage = (Math.ceil(currpage/10)*10-10)+1;
  }
  else {
    minpage = (Math.ceil(currpage/10)*10-10)+1;
  }

  var pagehtml = ''; var count = 0;
  for (i=minpage; i<=totpages; i++)
  {
    count+=1;
    if (count > 10) break;
    if (i == currpage)    
      pagehtml += '<span class="page-numbers current"><b>'+i+'</b></span>&nbsp;';
    else                                                                         
      pagehtml += '<a class="page-numbers" href="javascript:nav('+i+','+ url +','+form_name+')">'+i+'</a>&nbsp;';
  }
  $('#pageno').html(pagehtml);
} 


function nav(i,url,form_name)
{ 
  if (i > 0)
    $('#currpage').val(i);       
 
  if (i == 'i--')
    $('#currpage').val(1);
  else if (i == 'i++')
    $('#currpage').val($('#totpages').val());

 else if (i == 'i-')
    $('#currpage').val(parseInt($('#currpage').val()) - 1);
 else if (i == 'i+')
    $('#currpage').val(parseInt($('#currpage').val()) + 1);

 if (typeof(form_name) != "undefined") {
    document.forms[form_name].action = url+$('#currpage').val();
    document.forms[form_name].submit();                            
  }
 else{
     window.location = url+$('#currpage').val();
 }
}

