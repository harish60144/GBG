function showsecondparentinfo(){
	$('#addparent input').on('change',function(){
		if($(this).prop('id') == 'add'){
			$('#secondparentinfo').css({'height':'auto','width':'auto','visibility':'visible'});			
		}else{
			$('#secondparentinfo').css({'height':'0','width':'0','visibility':'hidden'});
		}
	});
}
function referchild(){
	$('#referchild input').on('change',function(e){		
		if($(this).prop('id') == 'parentorgardion'){
			$('#referalcondition,#medicalnomessage,#submitapplication').hide();
			$('#formdetails').removeClass('medical').addClass('parent');
		}else{
			$('#referalcondition,#submitapplication').show();
			$('#formdetails').removeClass('parent');
			$('#medicalnomessage').hide();
		}
	});
	$('#referalcondition input').on('change',function(e){
		if($(this).prop('id') == 'referchildyes'){
			$('#formdetails').addClass('medical');
			$('#submitapplication,#medicalnomessage').hide();
			
		}else{
			$('#formdetails').removeClass('medical');
			$('#medicalnomessage,#submitapplication').show();			
		}
	});
}
function nextandprev(){
	$('#next').on('click',function(){
		$('#subscriptionform').hide();
		$('#subscriptionform2,#prev,#submitapplication').show();
	});
	$('#prev').on('click',function(){		
		$('#subscriptionform').show();
		$('#subscriptionform2,#prev,#submitapplication').hide();
	});
}
function calender(){	
	$('.calender').datepicker({
		uiLibrary: 'bootstrap4',
		autoclose: 'true',		
	}).on('changeDate', function(e) {
			console.log(e.dates[0]);
           var date = e.dates[0].getDate();
		   var month = e.dates[0].getMonth();
		   var year = e.dates[0].getFullYear();
		   const monthNames = ["January", "February", "March", "April", "May", "June",
			  "July", "August", "September", "October", "November", "December"
			];
		   $('#month').val(monthNames[month]);
		   $('#year').val(year);
		   if(date <= 9){
				date = '0'+date;
		   }
		   $('#date').val(date);
        });	
}
jQuery(document).ready(function(){
	showsecondparentinfo();
	referchild();
	nextandprev();
	calender();	
});