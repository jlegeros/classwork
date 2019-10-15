const fetch = require("node-fetch");

fetch("https://www.spartan.com/en/race/find-race?cty=usa&month=may")
  .then(res => res.text())
  .then(body => {
    console.log("well, now what...");
    console.log(typeof body);
    let htmlArr = body.split(`<script type="text/javascript">`);
    htmlArr = htmlArr[1].split(`</script>`);
    htmlArr = htmlArr[0].split(`window.races = `);
    console.log(htmlArr[1].length);
    // console.log(htmlArr[1].trim().length);
    // console.log(htmlArr[1].substring(0, htmlArr[1].trim().length - 1));

    let jsonRaces = JSON.parse(
      htmlArr[1].substring(0, htmlArr[1].trim().length - 1)
    );

    // console.log(jsonRaces[123].subevents[0]);
    for (var event in jsonRaces) {
      console.log(jsonRaces[event]);
      // if (jsonRaces[event].venue.country == "USA") {
      //   console.log(jsonRaces[event].event_name);
      //   console.log(jsonRaces[event].start_date);
      //   for (var subevent in jsonRaces[event].subevents) {
      //     console.log(
      //       jsonRaces[event].subevents[subevent].category.category_name
      //     );
      //     for (var day in jsonRaces[event].subevents[subevent].ct_event_id) {
      //       console.log(
      //         `${jsonRaces[event].subevents[subevent].ct_event_id[day].day}: ${jsonRaces[event].subevents[subevent].ct_event_id[day].event}`
      //       );
      //     }
      //   }
      //   console.log(jsonRaces[event].venue);
      //   console.log("\n");
      // }
    }
  });

/* Data I want for site
  jsonRaces[i].event_name
  jsonRaces[i].subevents.category.category_name
  jsonRaces[i].subevents.parent_event_id
  jsonRaces[i].subevents.id
  jsonRaces[i].subevents.venue.address
  jsonRaces[i].subevents.venue.city
  jsonRaces[i].subevents.venue.state
  jsonRaces[i].subevents.venue.zip
  jsonRaces[i].subevents.venue.country
  jsonRaces[i].subevents.venue.latitude
  jsonRaces[i].subevents.venue.longitude
  jsonRaces[i].subevents.venue.name
  jsonRaces[i].subevents.start_date
  jsonRaces[i].subevents.end_date
  jsonRaces[i].subevents.ct_event_id.{objects}

  */
