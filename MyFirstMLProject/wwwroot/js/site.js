﻿function count() {
    const month = document.getElementById("chosenMonth").value;

    const d = new Date(Date.parse(month));
    const days = new Date(d.getFullYear(), d.getMonth() + 1, 0).getDate();
        
    document.getElementById("countDays").value = days;
}

function change() {
    document.getElementById('minutes').value = document.getElementById('selectAssignment').value;
}