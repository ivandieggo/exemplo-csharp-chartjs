$(document).ready(function () {

    //function transparentize(value, opacity) {
    //    var alpha = opacity === undefined ? 0.5 : 1 - opacity;
    //    return colorLib(value).alpha(alpha).rgbString();
    //}

    const data = {
        labels: ['0h', '2h', '4h', '6h', '8h', '10h', '12h', '14h', '16h', '18h', '20h', '22h'],
        datasets: [
            {
                label: 'Mensagens enviadas',
                data: [65, 59, 80, 81, 56, 55, 40, 88, 77, 12, 54, 27, 10, 85],
                borderColor: "rgba(55, 35, 251, 0.8)",
            },
            {
                label: 'Mensagens recebidas',
                data: [62, 9, 63, 55, 54, 85, 74, 77, 45, 12, 52, 47, 2, 48],
                borderColor: "rgba(244, 246, 10, 0.8)",
            },
            {
                label: 'Mensagens respondidas',
                data: [65, 39, 23, 53, 2, 25, 14, 57, 65, 17, 22, 57, 7, 9],
                borderColor: "rgba(30, 200, 49, 0.8)",
                /*backgroundColor: "rgba(244, 246, 10, 0.8)",*/
            }
        ]
    };

    const CHART = document.getElementById('grafico-line-chart-01');
    const config = new Chart(CHART, {
        type: 'line',
        data: data,
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'top',
                },
                title: {
                    display: true,
                    text: 'Chart.js Line Chart'
                }
            }
        },
    });

    //const config = {
    //    type: 'line',
    //    data: data,
    //    options: {
    //        responsive: true,
    //        plugins: {
    //            title: {
    //                display: true,
    //                text: (ctx) => 'Point Style: ' + ctx.chart.data.datasets[0].pointStyle,
    //            }
    //        }
    //    }
    //};



const actions = [
    {
        name: 'pointStyle: circle (default)',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'cirlce';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: cross',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'cross';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: crossRot',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'crossRot';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: dash',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'dash';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: line',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'line';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: rect',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'rect';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: rectRounded',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'rectRounded';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: rectRot',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'rectRot';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: star',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'star';
            });
            chart.update();
        }
    },
    {
        name: 'pointStyle: triangle',
        handler: (chart) => {
            chart.data.datasets.forEach(dataset => {
                dataset.pointStyle = 'triangle';
            });
            chart.update();
        }
    }
    ];

});