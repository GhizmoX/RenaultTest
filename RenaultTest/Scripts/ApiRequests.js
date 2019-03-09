function GeneralRequest(data, type, url) {
    $.ajax({
        type: type,
        url: url,
        data: JSON.stringify(data),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json'
    });
}

function GetStudents(url) {
    var studentsJsonPayload = $.getJSON(url);
    return studentsJsonPayload;
}

function GetSubjects(url) {
    var studentsJsonPayload = $.getJSON(url);
    return studentsJsonPayload;
}