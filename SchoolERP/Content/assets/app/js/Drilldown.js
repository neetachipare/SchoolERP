

    // Load the Visualization API and the corechart package.
    google.charts.load('current', {'packages': ['corechart'] });

        // Set a callback to run when the Google Visualization API is loaded.
        google.charts.setOnLoadCallback(drawChart);

        // Callback that creates and populates a data table,
        // instantiates the pie chart, passes in the data and
        // draws it.
        var a = 3.2;
var b = 2.2;
function drawChart() {
    debugger;
            // Create the data table.
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Topping');
            data.addColumn('number', 'Slices');
            data.addRows([
                ['Collected', b],
                ['Pending', a],
              
                //['Olives', 1],
                //['Zucchini', 1],
                //['Pepperoni', 2]
            ]);

            // Set chart options
            var options = {
        'title': 'Fee Collection',
                'width': 600,
                'height': 400
            };

            // Instantiate and draw our chart, passing in some options.
            var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
            chart.draw(data, options);



            // Add our selection handler.
            google.visualization.events.addListener(chart, 'select', selectHandler);

            // The selection handler.
            // Loop through all items in the selection and concatenate
            // a single message from all of them.
            function selectHandler() {
                var selection = chart.getSelection();

                var message = '';
                for (var i = 0; i < selection.length; i++) {
                    var item = selection[i];
                    console.log(item);
                    window.open("/dashboard/ChartStandard");
                    window.location.href = "/dashboard/ChartStandard";
                }
            }
        }
  