import { useEffect, useState } from "react";
import React from "react";
import { SERVER_URL } from "../constants.js";
import { DataGrid } from "@mui/x-data-grid";

const columns = [
  { field: "brand", headerName: "Brand", width: 200 },
  { field: "model", headerName: "Model", width: 200 },
  { field: "color", headerName: "Color", width: 200 },
  { field: "year", headerName: "Year", width: 150 },
  { field: "price", headerName: "Price", width: 150 },
];

function Carlist() {
  const [cars, setCars] = useState([]);
  useEffect(() => {
    fetch(SERVER_URL + "api/v1/cars")
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

      <div style={{ height: 500, width: '100%' }}>
        <DataGrid
          rows={cars}
          columns={columns}
          getRowId={(row) => row}
        />
      </div>
    </div>
  );
}

export default Carlist;
