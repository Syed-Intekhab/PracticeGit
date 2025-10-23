document.addEventListener('DOMContentLoaded', () => {
    const studentTable = document.getElementById('student-table');
    const filteredTable = document.getElementById('filtered-table');
    const courseFilter = document.getElementById('course-filter');

    courseFilter.addEventListener('change', () => {
        let isStudentFound = false;
        let courseTableHTML = `
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Email</th>
                <th>Course</th>
                <th>Is Top Student</th>
                <th>Edit</th>
            </tr>
        `;

        studentTable.querySelectorAll('tr').forEach((row, idx) => {
            if (idx > 0) {
                let courseString = row.querySelectorAll('td')[3].textContent.split(", ");

                courseString.forEach((course) => {
                    if (course.trim() === courseFilter.value) {
                        courseTableHTML += row.outerHTML;

                        isStudentFound = true;
                    }
                });
            }
        });

        if (isStudentFound)
            filteredTable.innerHTML = courseTableHTML;
        else
            filteredTable.innerHTML = "<p class='text-danger' style='padding: 10px 8px'>Student Not Found!</p>";
    });
});