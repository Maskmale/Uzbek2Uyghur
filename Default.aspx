<%@ Page Language="C#" MasterPageFile="~/Common/Public.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Uzbek2Uyghur_Default" Title="ئۆزبەكچە ئۇيغۇرچە تەرجىمە قىلغۇچ (Uzbek to Uyghur Online Tranclator)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="text-align: center">
                <br />
                ئۆزبەكچە- ئۇيغۇرچە تەرجىمە قىلغۇچ<br />
                <hr class="HorzentalLineHeader" dir="rtl" />
            </td>
        </tr>
        <tr>
            <td>
            
            
                <table cellpadding="0" dir="rtl" 
                    style="border-collapse: collapse; width: 600px; border: 1px solid #d5ddf3" align="center">
                    <tr>
                        <td dir="ltr">
                            <asp:TextBox ID="txtUzbek" runat="server" Height="200px" TextMode="MultiLine" 
                                Width="600px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center">
                            <asp:Button ID="btnTranclate" runat="server" onclick="btnTranclate_Click" 
                                Text="تەرجىمە قىلىش" />
                        </td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#CCCCFF">
                                                <asp:Literal ID="ltrlUyghur" runat="server"></asp:Literal>
                                            </td>
                                        </tr>
                                    </table>
                <br />
                <br />
                <br />
                مۇناسىۋەتلىك ئۇلىنىشلار<hr align="right" class="HorzentalLineLinks" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

