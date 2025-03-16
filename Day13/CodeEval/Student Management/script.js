document.getElementById('timetable-button').addEventListener('click', function() {
    const timetable = document.getElementById('timetable');
    if (timetable.classList.contains('d-none')) {
        timetable.classList.remove('d-none');
    } else {
        timetable.classList.add('d-none');
    }
});