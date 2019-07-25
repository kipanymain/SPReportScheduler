<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EngineAdmin._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
        <div class="row">
            <div class="col"><h2>Completes pending</h2></div>
            <div class="col"><h2>Partial Pending</h2></div>
            <div class="col"><h2>Leads not sent</h2></div>
        </div>
        <div class="row">
            <div class="col">
                <telerik:RadRadialGauge ID="RadRadialCompletes" runat="server">
                    <Pointer Value="2.2">
                        <Cap Size="0.1" />
                    </Pointer>
                    <Scale Min="0" Max="1000" MajorUnit="100">
                        <Labels Format="{0}" />
                        <Ranges>
                            <telerik:GaugeRange Color="#8dcb2a" From="0" To="100" />
                            <telerik:GaugeRange Color="#ffc700" From="101" To="200" />
                            <telerik:GaugeRange Color="#ff7a00" From="201" To="300" />
                            <telerik:GaugeRange Color="#c20000" From="301" To="1000" />
                        </Ranges>
                    </Scale>
                </telerik:RadRadialGauge>
                <asp:Label ID="Labelcomplete" runat="server" Text=""></asp:Label>

            </div>
            <div class="col">
                <telerik:RadRadialGauge ID="RadRadialPartials" runat="server">
                    <Pointer Value="2.2">
                        <Cap Size="0.1" />
                    </Pointer>
                    <Scale Min="0" Max="1000" MajorUnit="100">
                        <Labels Format="{0}" />
                        <Ranges>
                            <telerik:GaugeRange Color="#8dcb2a" From="0" To="100" />
                            <telerik:GaugeRange Color="#ffc700" From="101" To="200" />
                            <telerik:GaugeRange Color="#ff7a00" From="201" To="300" />
                            <telerik:GaugeRange Color="#c20000" From="301" To="1000" />
                        </Ranges>
                    </Scale>
                </telerik:RadRadialGauge>
                <asp:Label ID="Labelpartial" runat="server" Text=""></asp:Label>
            </div>
            <div class="col">
                <telerik:RadRadialGauge ID="RadRadialSendnew" runat="server">
                    <Pointer Value="2.2">
                        <Cap Size="0.1" />
                    </Pointer>
                    <Scale Min="0" Max="1000" MajorUnit="100">
                        <Labels Format="{0}" />
                        <Ranges>
                            <telerik:GaugeRange Color="#8dcb2a" From="0" To="100" />
                            <telerik:GaugeRange Color="#ffc700" From="101" To="200" />
                            <telerik:GaugeRange Color="#ff7a00" From="201" To="300" />
                            <telerik:GaugeRange Color="#c20000" From="301" To="1000" />
                        </Ranges>
                    </Scale>
                </telerik:RadRadialGauge>
                <asp:Label ID="Labelsendnew" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div>
            <hr />
        </div>
        <div class="row">
            <div class="col-4"><h2>Aged send pending</h2></div>
            <div class="col-8"><h2>Queues send pending</h2></div>
        </div>
        <div class="row">
            <div class="col-4">
              <telerik:RadRadialGauge ID="RadRadialAged" runat="server">
                    <Pointer Value="2.2">
                        <Cap Size="0.1" />
                    </Pointer>
                    <Scale Min="0" Max="1000" MajorUnit="100">
                        <Labels Format="{0}" />
                        <Ranges>
                            <telerik:GaugeRange Color="#8dcb2a" From="0" To="100" />
                            <telerik:GaugeRange Color="#ffc700" From="101" To="200" />
                            <telerik:GaugeRange Color="#ff7a00" From="201" To="300" />
                            <telerik:GaugeRange Color="#c20000" From="301" To="1000" />
                        </Ranges>
                    </Scale>
                </telerik:RadRadialGauge>
                <asp:Label ID="Labelaged" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-8">
<telerik:RadHtmlChart runat="server" ID="RadHtmlChart1">
    <PlotArea>
        <Series>
            <telerik:ColumnSeries Name="Products" DataFieldY="Count">
                <TooltipsAppearance />
                <LabelsAppearance Visible="false" />
            </telerik:ColumnSeries>
        </Series>
        <XAxis DataLabelsField="Name">
        </XAxis>
        <YAxis>
            <LabelsAppearance/>
        </YAxis>
    </PlotArea>
    <Legend>
        <Appearance Visible="false" />
    </Legend>
</telerik:RadHtmlChart>
            </div>
        </div>
    </div>




</asp:Content>
