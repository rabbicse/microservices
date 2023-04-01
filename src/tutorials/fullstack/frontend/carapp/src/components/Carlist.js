import { useEffect, useState } from "react";
import React from "react";

function Carlist() {
  const [cars, setCars] = useState([]);
  useEffect(() => {
    fetch(
      "http://localhost:8080/api/v1/cars",
      { crossDomain: true, method: "GET" }
    )
      .then((response) => response.json())
      .then((data) => {
        console.log(data);
        setCars(data);
      })
      .catch((err) => {
        console.error("Error...");
        console.error(err);
      });
  }, []);
  return (
    <div>
      <h1>Hello list</h1>

      <table>
        <tbody>
          {cars.map((car, index) => (
            <tr key={index}>
              <td>{car.brand}</td>
              <td>{car.model}</td>
              <td>{car.color}</td>
              <td>{car.year}</td>
              <td>{car.price}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Carlist;
