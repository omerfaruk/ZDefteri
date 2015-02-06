<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yonetim.aspx.cs" Inherits="ZDefteri.Yonetim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row">
                    <asp:TextBox ID="txtMesajID" runat="server"></asp:TextBox><asp:Button ID="btnOnayla" runat="server" Text="Onayla" OnClick="btnOnayla_Click" />
                    <asp:Button ID="btnSil" runat="server" Text="Sil" OnClick="btnSil_Click" />
                    <asp:Button ID="btnPasifYap" runat="server" Text="Pasif Yap" OnClick="btnPasifYap_Click" />
                    </div>
                <div class="row">
                    <asp:Label ID="lblSonuc" runat="server"></asp:Label>
                    <br />
            <asp:GridView ID="grdMesajlar" runat="server"></asp:GridView>

                </div>
                </div>
        </div>
    </form>
</body>
</html>
