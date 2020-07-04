function count() {
    const month = document.getElementById("chosenMonth").value;

    const d = new Date(Date.parse(month));
    const days = new Date(d.getFullYear(), d.getMonth() + 1, 0).getDate();
        
    document.getElementById("countDays").value = days;
}

function change() {
    document.getElementById('minutes').value = document.getElementById('selectAssignment').value;
}

function addCurrentMonth(field) {
    const date = new Date();
    const month = ("0" + (date.getMonth() + 1)).slice(-2);
    const year = date.getFullYear();
    field.value = `${year}-${month}`;
}

function populateTaskFields(taskId, tasks) {
    const division = document.getElementById('division');
    const section = document.getElementById('section');
    const minutes = document.getElementById('minutes');

    const currentTask = tasks.find(t => t.id === taskId);

    division.value = currentTask.department;
    section.value = currentTask.section;
    minutes.value = currentTask.minutes;
}