import { useState } from "react";

function Component() {
  let courses = [
    "Programowanie w C#",
    "Angular dla początkujących",
    "Kurs Django",
  ];

  const [name, setName] = useState("");
  const [courseNumber, setCourseNumber] = useState("");

  const formSubmit = (event) => {
    event.preventDefault();
    console.log(name);
    if (courses[courseNumber]) {
      console.log(courses[courseNumber - 1]);
    } else {
      console.log("Nieprawidłowy numer kursu");
    }
    setName("");
    setCourseNumber("");
  };

  return (
    <>
      <h2>Liczba kursów: {courses.length}</h2>
      <ol>
        {courses.map((course) => (
          <li key={course}>{course}</li>
        ))}
      </ol>
      <form>
        <div className="form-group">
          <label>Imię i nazwisko:</label>
          <input
            type="text"
            value={name}
            onChange={(e) => setName(e.target.value)}
            className="form-control"
          />
        </div>
        <div className="form-group">
          <label>Numer kursu:</label>
          <input
            type="text"
            value={courseNumber}
            onChange={(e) => setCourseNumber(e.target.value)}
            className="form-control"
          />
        </div>
        <button type="submit" onClick={formSubmit} className="btn btn-primary">
          Zapisz do kursu
        </button>
      </form>
    </>
  );
}

export default Component;
