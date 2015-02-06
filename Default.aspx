<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ZDefteri.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/benimStil.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <asp:DataList Width="100%" ID="dlMesajlar" runat="server">
                    <ItemTemplate>
                        <div class="panel panel-default">
                            <div class="panel-body">
                                <div class="col-md-2">
                                    <h4>
                                        <asp:Literal ID="Literal1" Text='<%# Eval("Ad") %>' runat="server"></asp:Literal></h4>
                                    <img src='<%# Eval("Avatar") %>' class="img-thumbnail" />
                                </div>
                                <div class="col-md-10">
                                    <asp:Literal ID="Literal2" Text='<%# Eval("Mesaj") %>' runat="server"></asp:Literal>
                                </div>
                            </div>
                        </div>

                    </ItemTemplate>
                </asp:DataList>
            </div>
            <div class="row">
                <h1>Mesaj Gönder</h1>
                <asp:Literal ID="ltrMesaj" runat="server"></asp:Literal>
                <div class="form-group">
                    <label>Ad</label>
                    <asp:TextBox ID="txtAd" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>E-Posta</label>
                    <asp:TextBox ID="txtEPosta" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Mesaj</label>
                    <asp:TextBox ID="txtMesaj" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="btnGonder" CssClass="btn btn-danger" runat="server" Text="Gönder" OnClick="btnGonder_Click" />
            </div>
        </div>
    </form>
</body>
</html>
