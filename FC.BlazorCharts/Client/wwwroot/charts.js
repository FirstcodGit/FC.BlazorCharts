///import 'apexcharts/apexcharts.js';

window.ChartResult = {

    starts: function (data, title) {

        setTimeout(() => {

            var options = {
                series: [{
                    data: data
                }],
                chart: {
                    type: 'candlestick',
                    height: 450
                },
                title: {
                    text: title,
                    align: 'left'
                },
                xaxis: {
                    type: 'datetime'
                },
                yaxis: {
                    tooltip: {
                        enabled: true
                    }
                }
            };

            var chart = new ApexCharts(document.querySelector("#chart"), options);
            chart.render();

        }, 300);
    }
}
