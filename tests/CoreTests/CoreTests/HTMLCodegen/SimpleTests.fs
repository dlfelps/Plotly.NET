module Tests.SimpleTests

open Expecto
open Plotly.NET
open Plotly.NET.LayoutObjects
open Plotly.NET.TraceObjects
open Plotly.NET.GenericChart

open TestUtils.HtmlCodegen
open Chart2DTestCharts

[<Tests>]
let ``Html layout tests`` =
    testList "SimpleTests.Simple tests" [
        testCase "Expecting plotly js script reference in generated html document" ( fun () ->
            $"""https://cdn.plot.ly/plotly-{Globals.PLOTLYJS_VERSION}.min"""
            |> substringIsInChart Chart2DTestCharts.Point.``Point chart with axis labels and title`` toEmbeddedHTML 
        );
        testCase "Expecting data" ( fun () ->
            Chart2DJsonReference.Point.``Point chart with axis labels and title``.Data
            |> chartGeneratedContains Chart2DTestCharts.Point.``Point chart with axis labels and title``
        );
        testCase "Expecting layout info" (fun () ->
            Chart2DJsonReference.Point.``Point chart with axis labels and title``.Layout
            |> chartGeneratedContains Chart2DTestCharts.Point.``Point chart with axis labels and title``
        );
        testCase "Expecting html tags in embedded page only" (fun () ->
            ["<html>"; "</html>"; "<head>"; "</head>"; "<body>"; "</body>"; "<script type=\"text/javascript\">"; "</script>"]
            |> substringListIsInChart Chart2DTestCharts.Point.``Point chart with axis labels and title`` toEmbeddedHTML
        );
        testCase "Expecting some html tags in both embedded and not embedded" (fun () ->
            ["<script type=\"text/javascript\">"; "</script>"]
            |> chartGeneratedContainsList Chart2DTestCharts.Point.``Point chart with axis labels and title``
        );
        testCase "Passing args to the function" ( fun () ->
            "data, layout, config);"
            |> chartGeneratedContains Chart2DTestCharts.Point.``Point chart with axis labels and title``
        )
    ]


[<Tests>]
let ``plotlyjs reference tests`` =
    testList "SimpleTests.plotlyjs reference" [
        testCase "full reference" (fun _ ->
            getFullPlotlyJS()
            |> substringIsInChart Chart2DTestCharts.Point.``Point chart with full plotly.js reference`` toEmbeddedHTML
        )
        testCase "cdn reference" (fun _ ->
            $"""https://cdn.plot.ly/plotly-2.0.0.min"""
            |> substringIsInChart Chart2DTestCharts.Point.``Point chart with plotly.js cdn reference`` toEmbeddedHTML 
        )
        testCase "require: Expecting cloudflare link" (fun () ->
            """https://cdnjs.cloudflare.com/ajax/libs/require.js"""
            |> chartGeneratedContains Chart2DTestCharts.Point.``Point chart referencing plotly.js using require.js``
        );
        testCase "require: Expecting require config" (fun () ->
            (sprintf """var fsharpPlotlyRequire = requirejs.config({context:'fsharp-plotly',paths:{plotly:'https://cdn.plot.ly/plotly-%s.min'}}) || require;""" Globals.PLOTLYJS_VERSION)
            |> chartGeneratedContains Chart2DTestCharts.Point.``Point chart referencing plotly.js using require.js``
        );
    ]