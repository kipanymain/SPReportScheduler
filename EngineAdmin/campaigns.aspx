<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="campaigns.aspx.cs" Inherits="EngineAdmin.campaigns" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div>
      <telerik:RadHtmlChart runat="server" ID="RadHtmlChart1" Width="1400px" Height="2000">
            <PlotArea>
                <Series>
                    <telerik:BarSeries DataFieldY="AcceptedCount" Name="Accepted">
                        <TooltipsAppearance Visible="false"></TooltipsAppearance>
                    </telerik:BarSeries>
                    <telerik:BarSeries DataFieldY="RejectedCount" Name="Rejected">
                        <TooltipsAppearance Visible="false"></TooltipsAppearance>
                    </telerik:BarSeries>
                    <telerik:BarSeries DataFieldY="UnknownCount" Name="Unknown">
                        <TooltipsAppearance Visible="false"></TooltipsAppearance>
                    </telerik:BarSeries>
                    <telerik:BarSeries DataFieldY="LimitCount" Name="Limit">
                        <TooltipsAppearance Visible="false"></TooltipsAppearance>
                    </telerik:BarSeries>                    
                    <telerik:BarSeries DataFieldY="QueuedCount" Name="Accepted">
                        <TooltipsAppearance Visible="false"></TooltipsAppearance>
                    </telerik:BarSeries>
                </Series>
                <XAxis DataLabelsField="Id">
                    <LabelsAppearance></LabelsAppearance>
                    <MajorGridLines Visible="false"></MajorGridLines>
                    <MinorGridLines Visible="false"></MinorGridLines>
                </XAxis>
                <YAxis>
                    <TitleAppearance Text="Count"></TitleAppearance>
                    <MinorGridLines Visible="false"></MinorGridLines>
                </YAxis>
            </PlotArea>
            <ChartTitle Text="Campaign results">
            </ChartTitle>
        </telerik:RadHtmlChart>

</div>
</asp:Content>
