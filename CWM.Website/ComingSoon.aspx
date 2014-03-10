<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComingSoon.aspx.cs" Inherits="CWM.Website.ComingSoon" %>

<!DOCTYPE html >
<!--[if IE 7 ]>    <html class="ie7" lang="en"> <![endif]-->
<!--[if IE 8 ]>    <html class="ie8" lang="en"> <![endif]-->
<!--[if IE 9 ]>    <html class="ie9" lang="en"> <![endif]--> 
<!--[if (gte IE 9)|!(IE)]><!--> <html class="no-js" lang="en"> <!--<![endif]-->

<head id="Head1" runat="server">
   <!-- Meta information -->
	<meta content="" charset="utf-8" />
	
	<title> CWM ~ Stay Classy Modesto!</title>
	<meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta name="robots" content="index, follow" /> 
	<meta name="SKYPE_TOOLBAR" content ="SKYPE_TOOLBAR_PARSER_COMPATIBLE"/>
	  
	<!-- favicon & idevice homepage thumb -->
	<link rel="shortcut icon" href="favicon.jpg" />
	
	<!--CSS Compressor-->
	    <!--Replace all css import statements with 1 of these options - see help file for more info.-->
	    <!-- option 1 -->
	    <!--<link rel="stylesheet" href="packs/jscsscomp.php?q=pack.css" />-->
	    <!-- option 2 -->
	    <!--<link rel="stylesheet" href="packs/pack.css" />-->
	<!--end css compressor-->
	
	<!-- main stylesheets -->
	<link rel="stylesheet" href="/Styles/reset.css" />
	<link rel="stylesheet" href="/Styles/960.css" />
	<link rel="stylesheet" href="/Styles/text.css" />
	<link rel="stylesheet" href="/Styles/style.css" />
	<link rel="stylesheet" href="/Styles/prettyPhoto.css" />
	
	<!-- color stylesheet -->
	<!--<link rel="stylesheet" href="css/dark.css" />-->
	
	
	<!--Js Compressor-->
	    <!--Replace all js import statements with 1 of these options - see help file for more info.-->
	    <!-- option 1 -->
	    <!--<script type="text/javascript" src="packs/jscsscomp.php?q=pack.js"></script>-->
	    <!-- option 2 -->
	    <!--<script type="text/javascript" src="packs/pack.js"></script>-->
	<!--end js compressor-->
	
	<!-- import jQuery -->
	<script type="text/javascript" src="/Scripts/jquery-1.4.4.min.js"></script>
	<script type="text/javascript" src="/Scripts/style.js"></script>
	<script type="text/javascript" src="/Scripts/jquery.easing.1.3.js"></script>
	<script type="text/javascript" src="/Scripts/jquery.fetch-tweets.js"></script>
	
	<!--import custom js file -->
	<script type="text/javascript" src="/Scripts/modernizr.custom.js"></script>
	<script type="text/javascript" src="/Scripts/jquery.pixelentity.utils.geom.js"></script>
	<script type="text/javascript" src="/Scripts/jquery.pixelentity.utils.ticker.js"></script>
	<script type="text/javascript" src="/Scripts/jquery.pixelentity.transform.js"></script>
	<script type="text/javascript" src="/Scripts/jquery.pixelentity.kenburns.js"></script>
	<script type="text/javascript" src="/Scripts/jquery.vid.js"></script>
	<script type="text/javascript" src="/Scripts/jquery.prettyPhoto.min.js"></script>
	<script type="text/javascript" src="/Scripts/slider.js"></script>
	<%--<script type="text/javascript" src="/Scripts/twitter.js"></script>--%>
	<script type="text/javascript" src="/Scripts/tagrotator.js"></script>
	<script type="text/javascript" src="/Scripts/faq.js"></script>
	<script type="text/javascript" src="/Scripts/contact.js"></script>
	<script type="text/javascript" src="/Scripts/newsletter.js"></script>
	<script type="text/javascript" src="/Scripts/gmap.js"></script>
	<script type="text/javascript" src="/Scripts/longinfo.js"></script>
	<script type="text/javascript" src="/Scripts/prettyPhoto.js"></script>
	<script type="text/javascript" src="/Scripts/gallery.js"></script>
	<script type="text/javascript" src="/Scripts/video.js"></script>
	
	<!-- font replacement -->
	<script type="text/javascript" src="/Scripts/cufon_ie9.js"></script>
	<script type="text/javascript" src="/Scripts/ArdleysHand_500.font.js"></script>
	<script type="text/javascript" src="/Scripts/Gotham_Narrow_Light_300.font.js"></script>
	<script type="text/javascript">
	    Cufon.replace('#lbNewsletter', { fontFamily: 'ArdleysHand' });
	    //Cufon.replace('#footer h3', { fontFamily: 'Gotham Narrow Light' });
	    Cufon.replace('#coming', { fontFamily: 'ArdleysHand' });

	</script>
</head>
<body class ="clearfix">
    <form id="form1" runat="server">
        <telerik:radscriptmanager 
        ID="RadScriptManager1" 
        runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            </Scripts>
        </telerik:radscriptmanager>
        <telerik:radajaxmanager 
        ID="RadAjaxManager1" 
        runat="server">
        <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="lbNewsletter">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="lblMessage" LoadingPanelID="RadAjaxLoadingPanel1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:radajaxmanager>
           <div id="siteWrapper" class="container_16">
       	
           <div id="main">
	    
		 <div id="header" class="grid_16">
	   	               
		    <!--logo-->
		    <h1 id="logoHead" class="grid_5">CWM</h1>
		    
           <!--newsletter signup form-->
	   			<div id="nl" data-default="youremail@yourdomain.com" data-subscribed="Thank you for subscribing.">
                <div style="margin-top: 25px; margin-left: 10px !important;">
	   				<asp:RegularExpressionValidator 
                        ID="valEmailAddress"
                        ControlToValidate="tbEmail"
                        ValidationExpression="^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" 
                        ErrorMessage="Email address is invalid." 
                        Display="Dynamic"
                        ForeColor="Red" 
                        EnableClientScript="true"
                        Runat="server"/>
                        <asp:RequiredFieldValidator
                        runat="server"
                        id="rfvb"
                        Display="Dynamic"
                        ErrorMessage="Enter Email Address."
                        InitialValue=""
                        ForeColor="Red"
                        ControlToValidate="tbEmail" />
                        <idea:Label
                        runat="server"
                        ID="lblMessage" />
                    </div>
                    <idea:TextBox 
                    runat="server" 
                    id="tbEmail" 
                    style="margin-left: 10px; margin-top: 0px;"
                    Width="230px"
                    Height="25px"
                    value=" youremail@yourdomain.com"
                    name="email">
                    </idea:TextBox>
	   				<%--<input type="submit" value="submit" />--%>
	   				<idea:LinkButton
                    runat="server"
                    style="font-size: 18px;"
                    ID="lbNewsletter"
                    OnClientClick="showMyDiv()"
                    OnClick="NewsletterClicked">
                        Sign up to our newsletter!
                    </idea:LinkButton>
	   			</div>
                <div style="font-size: 85px; margin-left: 10px; margin-top: 30px;">
                    <span id="coming" style="color: #000000;">
                        Coming Soon!!
                    </span>
                </div>

		   
	       </div>
           <div id="connect" class="grid_16" >
           &nbsp;
           </div>

	   	<!-- end header  -->
                    
	</div>  <!-- end site wrapper -->
    </form>
</body>
</html>
