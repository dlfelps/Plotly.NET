(**
// can't yet format YamlFrontmatter (["title: PointDensity"; "category: Distribution Charts"; "categoryindex: 5"; "index: 6"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 8 }) to pynb markdown

# PointDensity

[![Binder](https://plotly.net/img/badge-binder.svg)](https://mybinder.org/v2/gh/plotly/Plotly.NET/gh-pages?filepath=04_6_point-density.ipynb)&emsp;
[![Script](https://plotly.net/img/badge-script.svg)](https://plotly.net/04_6_point-density.fsx)&emsp;
[![Notebook](https://plotly.net/img/badge-notebook.svg)](https://plotly.net/04_6_point-density.ipynb)

*Summary:* This example shows how to create PointDensity plots in F#.

let's first create some data for the purpose of creating example charts:


*)
let rnd = new System.Random()
let x = [for i in 0 .. 100 -> rnd.NextDouble()]
let y = [for i in 0 .. 100 -> rnd.NextDouble()]
(**
`Chart.PointDensity` is a combination of a scatter plot and a histogram2dcontour.

It helps assessing the 2 dimensional distribution of a scatter plot by adding density contours based on the same data.

*)
open Plotly.NET

let pointDensityChart = 
    Chart.PointDensity(x,y)(* output: 
<div id="bfee3958-f748-4a9d-a75d-8a5da8da4694"><!-- Plotly chart will be drawn inside this DIV --></div>
<script type="text/javascript">

            var renderPlotly_bfee3958f7484a9da75d8a5da8da4694 = function() {
            var fsharpPlotlyRequire = requirejs.config({context:'fsharp-plotly',paths:{plotly:'https://cdn.plot.ly/plotly-2.6.3.min'}}) || require;
            fsharpPlotlyRequire(['plotly'], function(Plotly) {

            var data = [{"type":"histogram2dcontour","x":[0.9181095474129516,0.14827096130603368,0.7687360283994422,0.17131622213816655,0.2671439926421757,0.21083167186571883,0.37275037798828936,0.19852293646382846,0.6400658054160174,0.9464167685207466,0.5588104377753343,0.7579202621950336,0.21191032473676608,0.9020715982454183,0.6128221828708937,0.5428169379040002,0.9528729614867482,0.4070154656824735,0.9038018823230355,0.5473339804312368,0.1578024182400939,0.43753770184249563,0.2597703428332421,0.13410940237645586,0.18589937734201956,0.7876620399384022,0.8659505626438888,0.24690366728479507,0.2738399028920594,0.9223722858611431,0.25916355490602727,0.11517197069429885,0.7665134906190677,0.8282457004270786,0.12834296919679256,0.500819674499611,0.7050805390894843,0.12666324067184487,0.2278395849210717,0.8652265151790987,0.6626786284567345,0.11185021988144872,0.6342441904757578,0.8374029255832163,0.6979830483650848,0.6973633801737545,0.9182926602114382,0.5976706793003144,0.7087833232091777,0.9075883266740329,0.6115189765759428,0.8182602546722525,0.48147498117912657,0.0687977756689443,0.4890876687445773,0.214595755674042,0.24620728667565828,0.9895253499448724,0.865079155551499,0.3252488304346206,0.9371523560400499,0.05398362572817306,0.672560507170878,0.5007227515726147,0.966820483341765,0.8512064564386168,0.1505923536090752,0.8540797828213833,0.3020206133315194,0.2935151671822097,0.40922640411087363,0.5368912001081587,0.7471590324143988,0.5449870066789849,0.09799691805700594,0.093403399056328,0.22633234733072372,0.2808333945693119,0.21571731595291477,0.2561077390860771,0.5341728094507159,0.7124516038093264,0.1506852461296444,0.22795483745034484,0.695290306561537,0.05728924527594792,0.4354690140810298,0.36849678770241645,0.2061449332938885,0.8515715997707768,0.8498106252324876,0.875299712153075,0.6984608522152561,0.42980590516500117,0.5627070503330857,0.36474187473178044,0.7532259553217284,0.6785680194348589,0.8541877991593531,0.9718777640502881,0.7988361206533448],"y":[0.7235099466084342,0.6247441570608888,0.26686237459641915,0.7933387597411659,0.005349639005084006,0.08503072363370123,0.742364186121372,0.47414470316121304,0.19055804141712152,0.20292279423235493,0.0019057654712160144,0.5884215713652311,0.1915113606319655,0.9023077604178483,0.590188934803529,0.326520965632756,0.9313715848704948,0.6976759268724788,0.6970361420237098,0.998709633095443,0.425482174307793,0.8115192297324831,0.7473441963065531,0.14790827890477087,0.02571891921257652,0.11595468768805706,0.39248037155187177,0.7720498864692125,0.4482805629720177,0.4040572985263673,0.9284371116678977,0.07417990029747679,0.501557315328832,0.5370654793048246,0.9110518811141434,0.8409677619570732,0.7435104768837485,0.7695856332275393,0.7738512444518627,0.7640738962831902,0.8600138134759,0.3862917455597028,0.6371544621902052,0.472808994927691,0.24480932682933132,0.9437019724274661,0.7520204542939529,0.6581358144204,0.28551209297184665,0.3121237130814478,0.43379803293062513,0.4573732763396714,0.6025715413485115,0.402716817333689,0.7823452518647983,0.698123345537249,0.8127317099881669,0.8874458757828347,0.9033773635362956,0.5915057844560444,0.9548251001833189,0.7744244989248382,0.47565910032995773,0.8233598461759738,0.03391989418801411,0.8384906355159143,0.2783993306837632,0.15840934407586782,0.565051595251996,0.8397872199498658,0.8631872964911362,0.16863874973504778,0.3273006167494533,0.14704730621605355,0.7800134025222367,0.2684078448887335,0.03765692433499046,0.4839581666782671,0.11957815182750231,0.5201070193772378,0.9093139100876898,0.11328445368964102,0.19077370702869634,0.5037386493423001,0.4600191338441616,0.42217643276674843,0.06274746806541087,0.022107479470986346,0.6597798235155085,0.746754058169536,0.4972370910235536,0.0005297678440799869,0.9862813318765262,0.02648665564454744,0.06061577576790633,0.7850267781172794,0.6098558896025681,0.330534882364207,0.2735351097852927,0.3765704495681046,0.5307404260525603],"line":{"width":0.0},"contours":{"coloring":"fill","showlines":false}},{"type":"scatter","opacity":0.3,"mode":"markers","x":[0.9181095474129516,0.14827096130603368,0.7687360283994422,0.17131622213816655,0.2671439926421757,0.21083167186571883,0.37275037798828936,0.19852293646382846,0.6400658054160174,0.9464167685207466,0.5588104377753343,0.7579202621950336,0.21191032473676608,0.9020715982454183,0.6128221828708937,0.5428169379040002,0.9528729614867482,0.4070154656824735,0.9038018823230355,0.5473339804312368,0.1578024182400939,0.43753770184249563,0.2597703428332421,0.13410940237645586,0.18589937734201956,0.7876620399384022,0.8659505626438888,0.24690366728479507,0.2738399028920594,0.9223722858611431,0.25916355490602727,0.11517197069429885,0.7665134906190677,0.8282457004270786,0.12834296919679256,0.500819674499611,0.7050805390894843,0.12666324067184487,0.2278395849210717,0.8652265151790987,0.6626786284567345,0.11185021988144872,0.6342441904757578,0.8374029255832163,0.6979830483650848,0.6973633801737545,0.9182926602114382,0.5976706793003144,0.7087833232091777,0.9075883266740329,0.6115189765759428,0.8182602546722525,0.48147498117912657,0.0687977756689443,0.4890876687445773,0.214595755674042,0.24620728667565828,0.9895253499448724,0.865079155551499,0.3252488304346206,0.9371523560400499,0.05398362572817306,0.672560507170878,0.5007227515726147,0.966820483341765,0.8512064564386168,0.1505923536090752,0.8540797828213833,0.3020206133315194,0.2935151671822097,0.40922640411087363,0.5368912001081587,0.7471590324143988,0.5449870066789849,0.09799691805700594,0.093403399056328,0.22633234733072372,0.2808333945693119,0.21571731595291477,0.2561077390860771,0.5341728094507159,0.7124516038093264,0.1506852461296444,0.22795483745034484,0.695290306561537,0.05728924527594792,0.4354690140810298,0.36849678770241645,0.2061449332938885,0.8515715997707768,0.8498106252324876,0.875299712153075,0.6984608522152561,0.42980590516500117,0.5627070503330857,0.36474187473178044,0.7532259553217284,0.6785680194348589,0.8541877991593531,0.9718777640502881,0.7988361206533448],"y":[0.7235099466084342,0.6247441570608888,0.26686237459641915,0.7933387597411659,0.005349639005084006,0.08503072363370123,0.742364186121372,0.47414470316121304,0.19055804141712152,0.20292279423235493,0.0019057654712160144,0.5884215713652311,0.1915113606319655,0.9023077604178483,0.590188934803529,0.326520965632756,0.9313715848704948,0.6976759268724788,0.6970361420237098,0.998709633095443,0.425482174307793,0.8115192297324831,0.7473441963065531,0.14790827890477087,0.02571891921257652,0.11595468768805706,0.39248037155187177,0.7720498864692125,0.4482805629720177,0.4040572985263673,0.9284371116678977,0.07417990029747679,0.501557315328832,0.5370654793048246,0.9110518811141434,0.8409677619570732,0.7435104768837485,0.7695856332275393,0.7738512444518627,0.7640738962831902,0.8600138134759,0.3862917455597028,0.6371544621902052,0.472808994927691,0.24480932682933132,0.9437019724274661,0.7520204542939529,0.6581358144204,0.28551209297184665,0.3121237130814478,0.43379803293062513,0.4573732763396714,0.6025715413485115,0.402716817333689,0.7823452518647983,0.698123345537249,0.8127317099881669,0.8874458757828347,0.9033773635362956,0.5915057844560444,0.9548251001833189,0.7744244989248382,0.47565910032995773,0.8233598461759738,0.03391989418801411,0.8384906355159143,0.2783993306837632,0.15840934407586782,0.565051595251996,0.8397872199498658,0.8631872964911362,0.16863874973504778,0.3273006167494533,0.14704730621605355,0.7800134025222367,0.2684078448887335,0.03765692433499046,0.4839581666782671,0.11957815182750231,0.5201070193772378,0.9093139100876898,0.11328445368964102,0.19077370702869634,0.5037386493423001,0.4600191338441616,0.42217643276674843,0.06274746806541087,0.022107479470986346,0.6597798235155085,0.746754058169536,0.4972370910235536,0.0005297678440799869,0.9862813318765262,0.02648665564454744,0.06061577576790633,0.7850267781172794,0.6098558896025681,0.330534882364207,0.2735351097852927,0.3765704495681046,0.5307404260525603],"marker":{}}];
            var layout = {"width":600,"height":600,"template":{"layout":{"title":{"x":0.05},"font":{"color":"rgba(42, 63, 95, 1.0)"},"paper_bgcolor":"rgba(255, 255, 255, 1.0)","plot_bgcolor":"rgba(229, 236, 246, 1.0)","autotypenumbers":"strict","colorscale":{"diverging":[[0.0,"#8e0152"],[0.1,"#c51b7d"],[0.2,"#de77ae"],[0.3,"#f1b6da"],[0.4,"#fde0ef"],[0.5,"#f7f7f7"],[0.6,"#e6f5d0"],[0.7,"#b8e186"],[0.8,"#7fbc41"],[0.9,"#4d9221"],[1.0,"#276419"]],"sequential":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]],"sequentialminus":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]},"hovermode":"closest","hoverlabel":{"align":"left"},"coloraxis":{"colorbar":{"outlinewidth":0.0,"ticks":""}},"geo":{"showland":true,"landcolor":"rgba(229, 236, 246, 1.0)","showlakes":true,"lakecolor":"rgba(255, 255, 255, 1.0)","subunitcolor":"rgba(255, 255, 255, 1.0)","bgcolor":"rgba(255, 255, 255, 1.0)"},"mapbox":{"style":"light"},"polar":{"bgcolor":"rgba(229, 236, 246, 1.0)","radialaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","ticks":""},"angularaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","ticks":""}},"scene":{"xaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true},"yaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true},"zaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true}},"ternary":{"aaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"baxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"caxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"bgcolor":"rgba(229, 236, 246, 1.0)"},"xaxis":{"title":{"standoff":15},"ticks":"","automargin":true,"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","zerolinecolor":"rgba(255, 255, 255, 1.0)","zerolinewidth":2.0},"yaxis":{"title":{"standoff":15},"ticks":"","automargin":true,"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","zerolinecolor":"rgba(255, 255, 255, 1.0)","zerolinewidth":2.0},"annotationdefaults":{"arrowcolor":"#2a3f5f","arrowhead":0,"arrowwidth":1},"shapedefaults":{"line":{"color":"rgba(42, 63, 95, 1.0)"}},"colorway":["rgba(99, 110, 250, 1.0)","rgba(239, 85, 59, 1.0)","rgba(0, 204, 150, 1.0)","rgba(171, 99, 250, 1.0)","rgba(255, 161, 90, 1.0)","rgba(25, 211, 243, 1.0)","rgba(255, 102, 146, 1.0)","rgba(182, 232, 128, 1.0)","rgba(255, 151, 255, 1.0)","rgba(254, 203, 82, 1.0)"]},"data":{"bar":[{"marker":{"line":{"color":"rgba(229, 236, 246, 1.0)","width":0.5},"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}},"error_x":{"color":"rgba(42, 63, 95, 1.0)"},"error_y":{"color":"rgba(42, 63, 95, 1.0)"}}],"barpolar":[{"marker":{"line":{"color":"rgba(229, 236, 246, 1.0)","width":0.5},"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}}}],"carpet":[{"aaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","endlinecolor":"rgba(42, 63, 95, 1.0)","minorgridcolor":"rgba(255, 255, 255, 1.0)","startlinecolor":"rgba(42, 63, 95, 1.0)"},"baxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","endlinecolor":"rgba(42, 63, 95, 1.0)","minorgridcolor":"rgba(255, 255, 255, 1.0)","startlinecolor":"rgba(42, 63, 95, 1.0)"}}],"choropleth":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"contour":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"contourcarpet":[{"colorbar":{"outlinewidth":0.0,"ticks":""}}],"heatmap":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"heatmapgl":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"histogram":[{"marker":{"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}}}],"histogram2d":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"histogram2dcontour":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"mesh3d":[{"colorbar":{"outlinewidth":0.0,"ticks":""}}],"parcoords":[{"line":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"pie":[{"automargin":true}],"scatter":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatter3d":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}},"line":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattercarpet":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattergeo":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattergl":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattermapbox":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterpolar":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterpolargl":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterternary":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"surface":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"table":[{"cells":{"fill":{"color":"rgba(235, 240, 248, 1.0)"},"line":{"color":"rgba(255, 255, 255, 1.0)"}},"header":{"fill":{"color":"rgba(200, 212, 227, 1.0)"},"line":{"color":"rgba(255, 255, 255, 1.0)"}}}]}}};
            var config = {"responsive":true};
            Plotly.newPlot('bfee3958-f748-4a9d-a75d-8a5da8da4694', data, layout, config);
});
            };
            if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) {
                var script = document.createElement("script");
                script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js");
                script.onload = function(){
                    renderPlotly_bfee3958f7484a9da75d8a5da8da4694();
                };
                document.getElementsByTagName("head")[0].appendChild(script);
            }
            else {
                renderPlotly_bfee3958f7484a9da75d8a5da8da4694();
            }
</script>
*)
(**
## More styled example

This example shows the usage of some of the styling possibility using `Chart.PointDensity`.

*)
let pointDensityChartStyled = 
    Chart.PointDensity(
        x,
        y,
        PointMarkerColor = Color.fromKeyword Purple,
        PointMarkerSymbol = StyleParam.MarkerSymbol.X,
        PointMarkerSize = 4,
        ColorScale = StyleParam.Colorscale.Viridis,
        ColorBar = ColorBar.init(Title = Title.init("Density")),
        ShowContourLabels = true
    )(* output: 
<div id="81047c7a-4823-44e0-96c4-7bf8e540eea1"><!-- Plotly chart will be drawn inside this DIV --></div>
<script type="text/javascript">

            var renderPlotly_81047c7a482344e096c47bf8e540eea1 = function() {
            var fsharpPlotlyRequire = requirejs.config({context:'fsharp-plotly',paths:{plotly:'https://cdn.plot.ly/plotly-2.6.3.min'}}) || require;
            fsharpPlotlyRequire(['plotly'], function(Plotly) {

            var data = [{"type":"histogram2dcontour","x":[0.9181095474129516,0.14827096130603368,0.7687360283994422,0.17131622213816655,0.2671439926421757,0.21083167186571883,0.37275037798828936,0.19852293646382846,0.6400658054160174,0.9464167685207466,0.5588104377753343,0.7579202621950336,0.21191032473676608,0.9020715982454183,0.6128221828708937,0.5428169379040002,0.9528729614867482,0.4070154656824735,0.9038018823230355,0.5473339804312368,0.1578024182400939,0.43753770184249563,0.2597703428332421,0.13410940237645586,0.18589937734201956,0.7876620399384022,0.8659505626438888,0.24690366728479507,0.2738399028920594,0.9223722858611431,0.25916355490602727,0.11517197069429885,0.7665134906190677,0.8282457004270786,0.12834296919679256,0.500819674499611,0.7050805390894843,0.12666324067184487,0.2278395849210717,0.8652265151790987,0.6626786284567345,0.11185021988144872,0.6342441904757578,0.8374029255832163,0.6979830483650848,0.6973633801737545,0.9182926602114382,0.5976706793003144,0.7087833232091777,0.9075883266740329,0.6115189765759428,0.8182602546722525,0.48147498117912657,0.0687977756689443,0.4890876687445773,0.214595755674042,0.24620728667565828,0.9895253499448724,0.865079155551499,0.3252488304346206,0.9371523560400499,0.05398362572817306,0.672560507170878,0.5007227515726147,0.966820483341765,0.8512064564386168,0.1505923536090752,0.8540797828213833,0.3020206133315194,0.2935151671822097,0.40922640411087363,0.5368912001081587,0.7471590324143988,0.5449870066789849,0.09799691805700594,0.093403399056328,0.22633234733072372,0.2808333945693119,0.21571731595291477,0.2561077390860771,0.5341728094507159,0.7124516038093264,0.1506852461296444,0.22795483745034484,0.695290306561537,0.05728924527594792,0.4354690140810298,0.36849678770241645,0.2061449332938885,0.8515715997707768,0.8498106252324876,0.875299712153075,0.6984608522152561,0.42980590516500117,0.5627070503330857,0.36474187473178044,0.7532259553217284,0.6785680194348589,0.8541877991593531,0.9718777640502881,0.7988361206533448],"y":[0.7235099466084342,0.6247441570608888,0.26686237459641915,0.7933387597411659,0.005349639005084006,0.08503072363370123,0.742364186121372,0.47414470316121304,0.19055804141712152,0.20292279423235493,0.0019057654712160144,0.5884215713652311,0.1915113606319655,0.9023077604178483,0.590188934803529,0.326520965632756,0.9313715848704948,0.6976759268724788,0.6970361420237098,0.998709633095443,0.425482174307793,0.8115192297324831,0.7473441963065531,0.14790827890477087,0.02571891921257652,0.11595468768805706,0.39248037155187177,0.7720498864692125,0.4482805629720177,0.4040572985263673,0.9284371116678977,0.07417990029747679,0.501557315328832,0.5370654793048246,0.9110518811141434,0.8409677619570732,0.7435104768837485,0.7695856332275393,0.7738512444518627,0.7640738962831902,0.8600138134759,0.3862917455597028,0.6371544621902052,0.472808994927691,0.24480932682933132,0.9437019724274661,0.7520204542939529,0.6581358144204,0.28551209297184665,0.3121237130814478,0.43379803293062513,0.4573732763396714,0.6025715413485115,0.402716817333689,0.7823452518647983,0.698123345537249,0.8127317099881669,0.8874458757828347,0.9033773635362956,0.5915057844560444,0.9548251001833189,0.7744244989248382,0.47565910032995773,0.8233598461759738,0.03391989418801411,0.8384906355159143,0.2783993306837632,0.15840934407586782,0.565051595251996,0.8397872199498658,0.8631872964911362,0.16863874973504778,0.3273006167494533,0.14704730621605355,0.7800134025222367,0.2684078448887335,0.03765692433499046,0.4839581666782671,0.11957815182750231,0.5201070193772378,0.9093139100876898,0.11328445368964102,0.19077370702869634,0.5037386493423001,0.4600191338441616,0.42217643276674843,0.06274746806541087,0.022107479470986346,0.6597798235155085,0.746754058169536,0.4972370910235536,0.0005297678440799869,0.9862813318765262,0.02648665564454744,0.06061577576790633,0.7850267781172794,0.6098558896025681,0.330534882364207,0.2735351097852927,0.3765704495681046,0.5307404260525603],"line":{"width":0.0},"colorbar":{"title":{"text":"Density"}},"colorscale":"Viridis","contours":{"coloring":"fill","showlabels":true,"showlines":false}},{"type":"scatter","opacity":0.3,"mode":"markers","x":[0.9181095474129516,0.14827096130603368,0.7687360283994422,0.17131622213816655,0.2671439926421757,0.21083167186571883,0.37275037798828936,0.19852293646382846,0.6400658054160174,0.9464167685207466,0.5588104377753343,0.7579202621950336,0.21191032473676608,0.9020715982454183,0.6128221828708937,0.5428169379040002,0.9528729614867482,0.4070154656824735,0.9038018823230355,0.5473339804312368,0.1578024182400939,0.43753770184249563,0.2597703428332421,0.13410940237645586,0.18589937734201956,0.7876620399384022,0.8659505626438888,0.24690366728479507,0.2738399028920594,0.9223722858611431,0.25916355490602727,0.11517197069429885,0.7665134906190677,0.8282457004270786,0.12834296919679256,0.500819674499611,0.7050805390894843,0.12666324067184487,0.2278395849210717,0.8652265151790987,0.6626786284567345,0.11185021988144872,0.6342441904757578,0.8374029255832163,0.6979830483650848,0.6973633801737545,0.9182926602114382,0.5976706793003144,0.7087833232091777,0.9075883266740329,0.6115189765759428,0.8182602546722525,0.48147498117912657,0.0687977756689443,0.4890876687445773,0.214595755674042,0.24620728667565828,0.9895253499448724,0.865079155551499,0.3252488304346206,0.9371523560400499,0.05398362572817306,0.672560507170878,0.5007227515726147,0.966820483341765,0.8512064564386168,0.1505923536090752,0.8540797828213833,0.3020206133315194,0.2935151671822097,0.40922640411087363,0.5368912001081587,0.7471590324143988,0.5449870066789849,0.09799691805700594,0.093403399056328,0.22633234733072372,0.2808333945693119,0.21571731595291477,0.2561077390860771,0.5341728094507159,0.7124516038093264,0.1506852461296444,0.22795483745034484,0.695290306561537,0.05728924527594792,0.4354690140810298,0.36849678770241645,0.2061449332938885,0.8515715997707768,0.8498106252324876,0.875299712153075,0.6984608522152561,0.42980590516500117,0.5627070503330857,0.36474187473178044,0.7532259553217284,0.6785680194348589,0.8541877991593531,0.9718777640502881,0.7988361206533448],"y":[0.7235099466084342,0.6247441570608888,0.26686237459641915,0.7933387597411659,0.005349639005084006,0.08503072363370123,0.742364186121372,0.47414470316121304,0.19055804141712152,0.20292279423235493,0.0019057654712160144,0.5884215713652311,0.1915113606319655,0.9023077604178483,0.590188934803529,0.326520965632756,0.9313715848704948,0.6976759268724788,0.6970361420237098,0.998709633095443,0.425482174307793,0.8115192297324831,0.7473441963065531,0.14790827890477087,0.02571891921257652,0.11595468768805706,0.39248037155187177,0.7720498864692125,0.4482805629720177,0.4040572985263673,0.9284371116678977,0.07417990029747679,0.501557315328832,0.5370654793048246,0.9110518811141434,0.8409677619570732,0.7435104768837485,0.7695856332275393,0.7738512444518627,0.7640738962831902,0.8600138134759,0.3862917455597028,0.6371544621902052,0.472808994927691,0.24480932682933132,0.9437019724274661,0.7520204542939529,0.6581358144204,0.28551209297184665,0.3121237130814478,0.43379803293062513,0.4573732763396714,0.6025715413485115,0.402716817333689,0.7823452518647983,0.698123345537249,0.8127317099881669,0.8874458757828347,0.9033773635362956,0.5915057844560444,0.9548251001833189,0.7744244989248382,0.47565910032995773,0.8233598461759738,0.03391989418801411,0.8384906355159143,0.2783993306837632,0.15840934407586782,0.565051595251996,0.8397872199498658,0.8631872964911362,0.16863874973504778,0.3273006167494533,0.14704730621605355,0.7800134025222367,0.2684078448887335,0.03765692433499046,0.4839581666782671,0.11957815182750231,0.5201070193772378,0.9093139100876898,0.11328445368964102,0.19077370702869634,0.5037386493423001,0.4600191338441616,0.42217643276674843,0.06274746806541087,0.022107479470986346,0.6597798235155085,0.746754058169536,0.4972370910235536,0.0005297678440799869,0.9862813318765262,0.02648665564454744,0.06061577576790633,0.7850267781172794,0.6098558896025681,0.330534882364207,0.2735351097852927,0.3765704495681046,0.5307404260525603],"marker":{"color":"rgba(128, 0, 128, 1.0)","size":4,"symbol":"4"}}];
            var layout = {"width":600,"height":600,"template":{"layout":{"title":{"x":0.05},"font":{"color":"rgba(42, 63, 95, 1.0)"},"paper_bgcolor":"rgba(255, 255, 255, 1.0)","plot_bgcolor":"rgba(229, 236, 246, 1.0)","autotypenumbers":"strict","colorscale":{"diverging":[[0.0,"#8e0152"],[0.1,"#c51b7d"],[0.2,"#de77ae"],[0.3,"#f1b6da"],[0.4,"#fde0ef"],[0.5,"#f7f7f7"],[0.6,"#e6f5d0"],[0.7,"#b8e186"],[0.8,"#7fbc41"],[0.9,"#4d9221"],[1.0,"#276419"]],"sequential":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]],"sequentialminus":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]},"hovermode":"closest","hoverlabel":{"align":"left"},"coloraxis":{"colorbar":{"outlinewidth":0.0,"ticks":""}},"geo":{"showland":true,"landcolor":"rgba(229, 236, 246, 1.0)","showlakes":true,"lakecolor":"rgba(255, 255, 255, 1.0)","subunitcolor":"rgba(255, 255, 255, 1.0)","bgcolor":"rgba(255, 255, 255, 1.0)"},"mapbox":{"style":"light"},"polar":{"bgcolor":"rgba(229, 236, 246, 1.0)","radialaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","ticks":""},"angularaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","ticks":""}},"scene":{"xaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true},"yaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true},"zaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true}},"ternary":{"aaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"baxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"caxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"bgcolor":"rgba(229, 236, 246, 1.0)"},"xaxis":{"title":{"standoff":15},"ticks":"","automargin":true,"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","zerolinecolor":"rgba(255, 255, 255, 1.0)","zerolinewidth":2.0},"yaxis":{"title":{"standoff":15},"ticks":"","automargin":true,"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","zerolinecolor":"rgba(255, 255, 255, 1.0)","zerolinewidth":2.0},"annotationdefaults":{"arrowcolor":"#2a3f5f","arrowhead":0,"arrowwidth":1},"shapedefaults":{"line":{"color":"rgba(42, 63, 95, 1.0)"}},"colorway":["rgba(99, 110, 250, 1.0)","rgba(239, 85, 59, 1.0)","rgba(0, 204, 150, 1.0)","rgba(171, 99, 250, 1.0)","rgba(255, 161, 90, 1.0)","rgba(25, 211, 243, 1.0)","rgba(255, 102, 146, 1.0)","rgba(182, 232, 128, 1.0)","rgba(255, 151, 255, 1.0)","rgba(254, 203, 82, 1.0)"]},"data":{"bar":[{"marker":{"line":{"color":"rgba(229, 236, 246, 1.0)","width":0.5},"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}},"error_x":{"color":"rgba(42, 63, 95, 1.0)"},"error_y":{"color":"rgba(42, 63, 95, 1.0)"}}],"barpolar":[{"marker":{"line":{"color":"rgba(229, 236, 246, 1.0)","width":0.5},"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}}}],"carpet":[{"aaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","endlinecolor":"rgba(42, 63, 95, 1.0)","minorgridcolor":"rgba(255, 255, 255, 1.0)","startlinecolor":"rgba(42, 63, 95, 1.0)"},"baxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","endlinecolor":"rgba(42, 63, 95, 1.0)","minorgridcolor":"rgba(255, 255, 255, 1.0)","startlinecolor":"rgba(42, 63, 95, 1.0)"}}],"choropleth":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"contour":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"contourcarpet":[{"colorbar":{"outlinewidth":0.0,"ticks":""}}],"heatmap":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"heatmapgl":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"histogram":[{"marker":{"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}}}],"histogram2d":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"histogram2dcontour":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"mesh3d":[{"colorbar":{"outlinewidth":0.0,"ticks":""}}],"parcoords":[{"line":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"pie":[{"automargin":true}],"scatter":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatter3d":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}},"line":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattercarpet":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattergeo":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattergl":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattermapbox":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterpolar":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterpolargl":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterternary":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"surface":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"table":[{"cells":{"fill":{"color":"rgba(235, 240, 248, 1.0)"},"line":{"color":"rgba(255, 255, 255, 1.0)"}},"header":{"fill":{"color":"rgba(200, 212, 227, 1.0)"},"line":{"color":"rgba(255, 255, 255, 1.0)"}}}]}}};
            var config = {"responsive":true};
            Plotly.newPlot('81047c7a-4823-44e0-96c4-7bf8e540eea1', data, layout, config);
});
            };
            if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) {
                var script = document.createElement("script");
                script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js");
                script.onload = function(){
                    renderPlotly_81047c7a482344e096c47bf8e540eea1();
                };
                document.getElementsByTagName("head")[0].appendChild(script);
            }
            else {
                renderPlotly_81047c7a482344e096c47bf8e540eea1();
            }
</script>
*)

