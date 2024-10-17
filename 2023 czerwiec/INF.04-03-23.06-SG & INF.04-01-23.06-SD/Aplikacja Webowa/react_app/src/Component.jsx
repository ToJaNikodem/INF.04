import { useState } from "react";

function Component() {
  const [name, setName] = useState("");
  const [type, setType] = useState("");

  function formSubmit(event) {
    event.preventDefault();
    console.log("Tytuł: " + name + " Rodzaj: " + type);
  }

  return (
    <>
      <form>
        <label htmlFor="">Tytuł filmu:</label>
        <input
          type="text"
          className="form-control"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />

        <label htmlFor="">Rodzaj</label>
        <select
          name=""
          id=""
          className="form-control"
          value={type}
          onChange={(e) => setType(e.target.value)}
        >
          <option value=""></option>
          <option value="1">Komedia</option>
          <option value="2">Obyczajowy</option>
          <option value="3">Sensacyjny</option>
          <option value="4">Horror</option>
        </select>

        <button className="btn btn-primary" onClick={formSubmit}>
          Rodzaj
        </button>
      </form>
    </>
  );
}

export default Component;
