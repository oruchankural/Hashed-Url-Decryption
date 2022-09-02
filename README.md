# Hashed-Url-Decryption
Hashed Url Decryption

<h1>How to use Hashed Url</h1>
<p class="text-danger">Click the Arrow to see description on it.</p>

<h3><button class="bi bi-arrow-down btn-outline-danger" id="createEndPoint_Arrow" onclick="ShowOrHide('createEndPoint_Div');"></button> Create End Point Map</h3>
<div id="createEndPoint_Div" style="display:none;">

    <code>

        endpoints.Map("SetPassword", new SetPasswordHandler().Handler());

    </code>
    <br />
    <span>
        <b class="text-danger">-</b>
        U ll use an action named <b>"SetPassword"</b>
        then <b>SetPasswordHandler</b> class ll be handle this request with out Controller based.
    </span>
    <hr />
</div>
<h3><button class="bi bi-arrow-down btn-outline-danger" id="workWithBCrypt_Arrow" onclick="ShowOrHide('workWithBCrypt_Div');"></button> How to work with BCrypt</h3>
<div class="pre-scrollable" id="workWithBCrypt_Div" style="display:none;">
    <img src="https://i.hizliresim.com/il0b5up.PNG" />
    <hr />
</div>
<h3><button class="bi bi-arrow-down btn-outline-danger" id="howToHandle_Arrow" onclick="ShowOrHide('howToHandle_Div');"></button> How to handle Request Parameter</h3>
<div id="howToHandle_Div" style="display:none;">
    <code>
        using Microsoft.AspNetCore.Http;
    </code>
    <br />
    <span><b class="text-danger">-</b> Add this name space on it.</span>
    <div class="pre-scrollable">
        <img src="https://i.hizliresim.com/cnbzlg4.PNG" />
    </div>
    <br />
    <span>
        <b class="text-danger">-</b> When <b>/SetPassword</b> is requested , this class ll handle it.
        <br />
        <b class="text-danger">-</b> If requested url query parameter <b>named email</b> is not empty or the data stored as the relevant hash
        <b>(from hashedEmailList)</b> in our system.
        <br />
        <b class="text-danger">-</b> ! Requested url must be : <b>/SetPassword?email=HashInstance</b>
        <br />
        <b class="text-danger">-</b> When this hash key matched via our any hashedEmailList item , we ll find unhashed version of it.
        Then return an action via unhashed email for any work of business.
        <br />
        <b class="text-danger">-</b> If there is no hash key that coming from RouteData , write response that 'It's not registered email....' ext.
    </span>
</div>
