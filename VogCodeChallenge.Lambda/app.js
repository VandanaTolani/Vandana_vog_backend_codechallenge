'use strict';
var AWS = require("aws-sdk");

exports.handler = function (event, context) {

    if (event != null) {
        event.Records.forEach((record) => {
            console.log('DynamoDb Stream record received: ', JSON.stringify(record, null, 2));

            if (record.eventName == 'INSERT') {
                var recordId = JSON.stringify(record.dynamodb.NewImage.RecordId.S);
                console.log(`RecordId ${recordId} was inserted in the table`);
            }
        });
    }
    else {
        console.log('No event object');

    }

    context.done(null, 'Successfully finished processing DynamoDb events');
};
