/* this file contains all the displayable text use in javascript*/
// Syntax: var MACRO = 'displayable text'

//minimum and maximun character in reply of a topic
var min_replytext 	= "Reply text must be minimun of ";
var max_replytext 	= "Reply text must be maximum of ";
var caharacyet		= " character";	


function form_reply_minchar(minchar)
{
	alert(min_replytext+minchar+caharacyet);
}

function form_reply_maxchar(maxchar)
{
	alert(max_replytext+maxchar+caharacyet);
}

function frm_topic_delete()
{
	alert("Topic is Deleted");
}

function frm_topic_inactivate()
{
	alert("Topic is Inactivated");
}

function frm_topic_reply_delete_alert()
{
	alert("Reply deleted");
}

function frm_topic_reply_delete_verify()
{
	return confirm("Do you want to delete this reply?");	
}

function frm_topic_reply_edit_verify()
{
	return confirm("Do you want to save this reply?");	
}

function frm_topic_reply_edit_moderate_verify()
{
	return confirm("Your reply will be published after moderation.\nDo you want to save this reply?");	
}

function frm_topic_reply_add_verify()
{
	return confirm("Do you want to add reply?");	
}

function frm_topic_reply_add_moderate_verify()
{
	return confirm("Your reply will be published after moderation.\nDo you want to add reply?");	
}

function frm_topic_adminoption_savealert()
{
	alert("Admin option saved");
}

function frm_forum_topic_delete_verify()
{
	return confirm("Do you want to delete this topic?");	
}

function frm_forum_topic_delete_alert()
{
	alert("Topic deleted");
}

function frm_topic_adminoption_saved_alert()
{
	alert("Topic options saved");
}

function frm_topic_moderate_verify()
{
	return confirm("Do you want to moderate selected topic(s)?");
}


function frm_topic_adminoption_miss(type){

	switch (type)
	{
		case 'owner':
			alert('Invalid Owner Name');
			break;
		case 'issue_id':
			alert('Invalid Issue id. Issue id should be numeric.');
			break;
	}

}

function frm_topic_edit_verify(){

	return confirm("Are you sure to save topic?");
}

function frm_topic_miss(type){

	switch (type)
	{
		case 'topic_title':
			alert('Please enter Topic title.');
			break;
		case 'topic_text':
			alert('Please enter topic description.');
			break;
		case 'topic_forum_name':
			alert('Please select a forum');
			break;
	}

}

function frm_no_access(action){

	switch (action)
	{

		case 'forum_logged_in':
			alert('You do not have view right on this forum.\n Please contact forum administrator.');
			break;

		case 'forum_no_logged_in':
			alert('Please log in to view forum.');
			break;

		case 'topic_logged_in':
			alert('You do not have view right on this topic.\n Please contact forum administrator.');
			break;

		case 'topic_no_logged_in':
			alert('Please log in to view topic.');
			break;
		
		case 'reply_logged_in':
			alert('You do not have view right on this forum.\n Please contact forum administrator.');
			break;

		case 'reply_no_logged_in':
			alert('Please log in to view forum.');
			break;
	
	}



}


function frm_topic_answered_verify()
{
	return confirm("Are you sure to set current topic as answered?")
}


function frm_topic_best_answered_verify()
{
	return confirm("Are you sure to set current reply as best reply?")
}

function frm_topic_answered_msg(action)
{
	switch (action)
	{
		case 'answered':
			alert('Your topic is set as Answered.');
			break;
		case 'not_answered':
			alert('Topic is not set as Answered.');
			break;

		case 'best_answered':
			alert('Selected reply has been set as best reply.');
			break;
		case 'not_answered':
			alert('Selected reply is not set as best reply.');
			break;
	}
}

function frm_topic_multiupdate_verify()
{
	return confirm("Do you want to update topic?");	
}

function frm_topic_multiupdate_alert()
{
	alert("Selected topic update successfully.");	
}

function frm_topic_multiupdate_restrict_alert()
{
	alert("Please select atleast one topic.");	
}

function frm_topic_subscribe_verify(check)
{
	if(check == "YES"){
		return confirm("Do you want subscribe to this topic?");		
	}
	else{
		return confirm("Do you want unsubscribe to this topic?");	
	}	
}

function frm_topic_subscribe_alert(check)
{
	if(check == "YES"){
		alert("You have subscribed to this topic Successfully.");		
	}
	else{
		alert("You have unsubscribed to this topic Successfully.");	
	}
}
function frm_topic_change_forum(){
	return confirm("Are you sure to change forum?");
}

function frm_select_forum_id(){
	alert("Please select forum");
}


function frm_forum_subscribe_alert(check)
{
	if(check == "YES"){
		alert("You have successfully subscribed to this forum.");		
	}
	else{
		alert("You have successfully unsubscribed to this forum.");	
	}
}

function frm_topic_cancel_msg(){
	return confirm("You are about to go out of this page. Continue?");
}

function frm_select_one_post(){
	return alert('Please select atleast one post to move.');
}

function frm_select_one_thread(){
	return alert('Please select atleast one thread to move.');
}

function frm_select_two_thread(){
	return alert('Please select atleast two thread to merge.');
}

function frm_select_one_thread_merge(){
	return alert('Please select atleast one thread to merge.');
}

function frm_topic_reply_abuse_verify()
{
	return confirm("Are you sure?");	
}

function frm_topic_reply_abuse_alert()
{
	alert("Reply reported for abuse.");
}
