import React, { useState, useEffect } from 'react'
import { DataGrid } from '@mui/x-data-grid'
import axios from 'axios';
const columns = [
  { field: 'id', headerName: 'ID',width: 300 },
  { field: 'title', headerName: 'Title', width: 300 },
  { field: 'content', headerName: 'Content', width: 300 },
  { field: 'createdDate', headerName: 'CreatedDate', width: 300 }
]


function getData(){
  axios.get('https://localhost:44324/api/announcements')
        .then(response => console.log("AXIOS DATA : "+JSON.stringify(response.data)));
}

const DataTable= () => {
  getData();
  const [tableData, setTableData] = useState([])

  useEffect(() => {
    axios.get('https://localhost:44324/api/announcements')
    .then(response =>  setTableData(response.data));
  }, [])

  console.log(tableData)



  return (
    <div style={{ height: 700, width: '100%' }}>
      <DataGrid
        rows={tableData}
        columns={columns}
        pageSize={12}
      />
    </div>
  )
}

export default DataTable