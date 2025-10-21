document.addEventListener('DOMContentLoaded', function () {
    const studentTable = document.getElementById('student-table');
    const filteredTable = document.getElementById('filtered-table');
    const courseFilter = document.getElementById('course-filter');

    courseFilter.addEventListener('change', function () {
        let isStudentFound = false;
        let courseTableHTML = `
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Email</th>
                <th>Course</th>
                <th>Edit</th>
            </tr>
        `;

        studentTable.querySelectorAll('tr').forEach((row, idx) => {
            if (idx > 0) {
                if (row.querySelectorAll('td')[3].textContent === courseFilter.value) {
                    courseTableHTML += row.outerHTML;

                    isStudentFound = true;
                }
            }
        });

        if (isStudentFound)
            filteredTable.innerHTML = courseTableHTML;
        else
            filteredTable.innerHTML = "<p class='text-danger' style='padding: 10px 8px'>Student Not Found!</p>";
    });
});