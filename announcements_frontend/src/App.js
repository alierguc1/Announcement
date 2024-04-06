import logo from './logo.svg';
import './App.css';
import Box from '@mui/material/Box';
import  DataTable  from '../src/components/common/DataGrid';
import React, { useState, useEffect } from 'react'


function App() {
  return (
    <div className="App">
    <p>announcements</p>
     <DataTable/>
    </div>
  );
}

export default App;
