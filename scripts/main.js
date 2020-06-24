

    var randomScalingFactor = function() {
      return Math.round(Math.random() * 100);
    };
  window.chartColors = {
    red: 'rgb(255, 99, 132)',
    orange: 'rgb(255, 159, 64)',
    yellow: 'rgb(255, 205, 86)',
    green: 'rgb(75, 192, 192)',
    blue: 'rgb(54, 162, 235)',
    purple: 'rgb(153, 102, 255)',
    grey: 'rgb(201, 203, 207)'
  };
    var datapoints = [0, 20, 20, 60, 60, 120, NaN, 180, 120, 125, 105, 110, 170];
    var config = {
      type: 'line',
        data: {
        labels: ['0', '1', '2', '3', '4', '5']
      },
      options: {
        responsive: true,
        tooltips: {
          mode: 'index'
        },
        scales: {
          xAxes: [{
            display: true,
            scaleLabel: {
              display: true,
              labelString: 'Elongation'
            }
          }],
          yAxes: [{
            display: true,
            scaleLabel: {
              display: true,
              labelString: 'Load'
            },
            ticks: {
              suggestedMin: 0,
              suggestedMax: 200,
            }
          }],
          height:600,
          width:900
        }
      }
    };

    window.onload = function() {
      var ctx = document.getElementById('canvas').getContext('2d');
      window.myLine = new Chart(ctx, config);
    };
  
// google.charts.load('current', {packages: ['corechart']});
// google.charts.setOnLoadCallback(drawCurveTypes);

// function drawCurveTypes() {
//       var data = new google.visualization.DataTable();
//       data.addColumn('number', 'X');
//       data.addColumn('number', 'Y');

//       data.addRows([
//         [0, 0],    [1, 10],   [2, 20],  [3, 30],   [4, 40],  [5, 50]
//       ]);

//       var options = { 
//         series: {
//           0: {curveType: 'function',visibleInLegend:false},
//           1: {curveType: 'function'}
//         },
//         height:540,
//         width:900,
//         hAxis:{
//             title: 'Elongation'
//         },
//         vAxis:{
//           title: 'Load',
//           viewWindowMode:'maximized',
//           gridlines:{count: 10}
//         },
//         chartArea:{left:50,top:10,width:'90%',height:'90%'}
//       };

//       var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
//       chart.draw(data, options);
//     }

    function TEST(){
      $('.TESTING').fadeIn();
      $('.graph').attr('style','opacity:1')
    }
    $('.history').click(function(){
      $('.TESTING').fadeOut();
      $('.graph').attr('style','opacity:0')
      $('#history').fadeIn();
    })
    $('.exitH').click(function(){
      $('.TESTING').fadeIn();
      $('.graph').attr('style','opacity:1')
      $('#history').fadeOut();
    })
    $('.inputS').click(function(){
      $('#input').fadeIn();
      $('.TESTING').fadeOut();
      $('.graph').attr('style','opacity:0')
      $('#history').fadeOut();
    })
    $('.datetimepicker').datetimepicker({
    icons: {
        time: "fa fa-clock-o",
        date: "fa fa-calendar",
        up: "fa fa-chevron-up",
        down: "fa fa-chevron-down",
        previous: 'fa fa-chevron-left',
        next: 'fa fa-chevron-right',
        today: 'fa fa-screenshot',
        clear: 'fa fa-trash',
        close: 'fa fa-remove'
    }
});