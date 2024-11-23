<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CadastrarVenda.aspx.cs" Inherits="CadastrarVenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #Text1
        {
            width: 144px;
        }
        #BtnSave
        {
            width: 72px;
        }
        #Text2
        {
            width: 202px;
        }
        #Text3
        {
            width: 179px;
        }
        #Select1
        {
            width: 143px;
            height: 26px;
        }
        #Select2
        {
            height: 21px;
            width: 138px;
        }
        #Select3
        {
            height: 16px;
            width: 127px;
        }
        #BtnBuscar2
        {
            height: 33px;
            width: 77px;
        }
        #BtnBuscar
        {
            height: 33px;
            width: 70px;
        }
        #SelectFuncionario
        {
            height: 33px;
            width: 131px;
        }
        #SelectCliente
        {
            height: 12px;
            width: 132px;
        }
        #SelectItemVenda
        {
            height: 22px;
            width: 144px;
        }
        .style2
        {
            width: 312px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="style2">
                Data Venda:<asp:TextBox 
                    ID="TxtDataVenda" runat="server" Height="23px" 
                    Width="164px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TxtDataVenda" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Numero Nota Fiscal:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="BtnSave" runat="server" Text="Salvar" />
                <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </asp:Content>

