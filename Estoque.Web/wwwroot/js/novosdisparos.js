$(document).ready(function () {
    const WEEKDAY = ['DOM', 'SEG', 'TER', 'QUA', 'QUI', 'SEX', 'SAB']

    const labels = [
        'January',
        'February',
        'March',
        'April',
        'May',
        'June',
        'July'
    ];
    const data = {
        labels: WEEKDAY,
        datasets: [
            {
                label: 'Mensagens Disparadas',
                data: [10, 25, 50, 75, 22, 32, 21],
                borderColor: "rgba(244, 246, 10, 0.8)",
                backgroundColor: "rgba(244, 246, 10, 0.5)",
                minBarLength: 2,
            },
            {
                label: 'Mensagens Recebidas',
                data: [8, 25, 49, 60, 20, 7, 14],
                borderColor: "rgba(75, 192, 192, 1)",
                backgroundColor: "rgba(75, 192, 192, 0.5)",
                minBarLength: 2,
            }
        ]
    };

    const CHART = document.getElementById('grafico-vertical-bar-01');
    const config = new Chart(CHART, {
        type: 'bar',
        data: data,
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
    //const config = {
    //    type: 'bar',
    //    data: data,
    //    options: {
    //        responsive: true,
    //        plugins: {
    //            legend: {
    //                position: 'top',
    //            },
    //            title: {
    //                display: true,
    //                text: 'Chart.js Bar Chart'
    //            }
    //        }
    //    },
    //};



    const actions = [
        {
            name: 'Randomize',
            handler(chart) {
                chart.data.datasets.forEach(dataset => {
                    dataset.data = Utils.numbers({ count: chart.data.labels.length, min: -100, max: 100 });
                });
                chart.update();
            }
        },
        {
            name: 'Add Dataset',
            handler(chart) {
                const data = chart.data;
                const dsColor = Utils.namedColor(chart.data.datasets.length);
                const newDataset = {
                    label: 'Dataset ' + (data.datasets.length + 1),
                    backgroundColor: Utils.transparentize(dsColor, 0.5),
                    borderColor: dsColor,
                    borderWidth: 1,
                    data: Utils.numbers({ count: data.labels.length, min: -100, max: 100 }),
                };
                chart.data.datasets.push(newDataset);
                chart.update();
            }
        },
        {
            name: 'Add Data',
            handler(chart) {
                const data = chart.data;
                if (data.datasets.length > 0) {
                    data.labels = Utils.months({ count: data.labels.length + 1 });

                    for (let index = 0; index < data.datasets.length; ++index) {
                        data.datasets[index].data.push(Utils.rand(-100, 100));
                    }

                    chart.update();
                }
            }
        },
        {
            name: 'Remove Dataset',
            handler(chart) {
                chart.data.datasets.pop();
                chart.update();
            }
        },
        {
            name: 'Remove Data',
            handler(chart) {
                chart.data.labels.splice(-1, 1); // remove the label first

                chart.data.datasets.forEach(dataset => {
                    dataset.data.pop();
                });

                chart.update();
            }
        }
    ];

});