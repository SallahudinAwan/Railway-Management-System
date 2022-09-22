<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Call asp.net server side functions from JavaScript using AJAX PageMethods</title>

    <script type="text/javascript">

        function MyFunction() {
            //Get values from textboxes that wiil be passed to function          
            var num1 = document.getElementById('<%=txtFirstNumber.ClientID %>').value;
            var num2 = document.getElementById('<%=txtSecondNumber.ClientID %>').value;
            
            PageMethods.CalculateSum(num1, num2, onSucess, onError);
            alert("Enter");
            function onSucess(result) {
                $get('dvMsg').innerHTML ="Sum of " + num1 + " and " + num2 + " = " +  result;
            }

            function onError(error) {
                alert("Error: " + error.get_message());               
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>

            <table>
                <tr>
                    <td>Enter First Number:</td>
                    <td>
                        <asp:TextBox ID="txtFirstNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td>Enter Second Number:</td>
                    <td>
                        <asp:TextBox ID="txtSecondNumber" runat="server" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClientClick="MyFunction();return false;" />
                        <div id="dvMsg"></div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
