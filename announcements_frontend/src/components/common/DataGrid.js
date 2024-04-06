import React, { useState, useEffect } from 'react'
import { DataGrid } from '@mui/x-data-grid'
import axios from 'axios';
import TextField from '@mui/material/TextField';
import Grid from '@mui/material/Grid';
import Button from '@mui/material/Button';
import Accordion from '@mui/material/Accordion';
import AccordionActions from '@mui/material/AccordionActions';
import AccordionSummary from '@mui/material/AccordionSummary';
import AccordionDetails from '@mui/material/AccordionDetails';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import Snackbar from '@mui/material/Snackbar';
import Alert from '@mui/material/Alert';


const columns = [
  { field: 'id', headerName: 'ID',width: 300 },
  { field: 'title', headerName: 'Title', width: 300 },
  { field: 'content', headerName: 'Content', width: 300 },
  { field: 'createdDate', headerName: 'CreatedDate', width: 300 }
]



const DataTable= () => {
  function openAlert(isCorrect){
    setOpen(true);
    if(isCorrect == true){
      setAlertMessage('Annouchment Adding...')
      setAlertSeverity('success')
    }else{
      setAlertMessage('Annouchment Not Adding...')
      setAlertSeverity('error')
    }
  }
  const [alertMessage, setAlertMessage] = useState([])
  const [alertSeverity, setAlertSeverity] = useState([])
  const [open, setOpen] = React.useState(false);
  const [tableData, setTableData] = useState([])
  const [title, setTitle] = useState("");
  const [content, setContent] = useState("");


  const handleClose = (event, reason) => {
    if (reason === 'clickaway') {
      return;
    }
    setOpen(false);
  };


  useEffect(() => {
    axios.get('https://localhost:44324/api/announcements')
    .then(response =>  setTableData(response.data));
  }, [])

    const addAnnouchments = () => {
    if(title == '' || content == ''){
      openAlert(false);
    }else{
      axios.post("https://localhost:44324/api/announcements", {
        title: title,
        content: content
      })
      .then((response) => {
          openAlert(true); 
          axios.get('https://localhost:44324/api/announcements')
          .then(response =>  setTableData(response.data))    
      });
    }

    };

    const handleTitleTextFieldChange = (event) => {
      setTitle(event.target.value);
    };

    const handleContentTextFieldChange = (event) => {
      setContent(event.target.value);
    };

  return (
    <div style={{ height: 700, width: '100%' }}>   

      <Accordion>
        <AccordionSummary
          expandIcon={<ExpandMoreIcon />}
          aria-controls="panel1-content"
          id="panel1-header"
        >
          Add Annouchement Settings
        </AccordionSummary>
        <AccordionDetails>
        <Grid container rowSpacing={1} columnSpacing={{ xs: 12, sm: 12, md: 12 }}>
          <Grid item xs={12}>
          <TextField value={title} onChange={handleTitleTextFieldChange} label="Title" color="primary" focused />

          </Grid>
          <Grid item xs={12}>
          <TextField value={content} onChange={handleContentTextFieldChange} label="Content" color="primary" focused />

          </Grid>
          <Grid item xs={12}>
          <Button onClick={addAnnouchments} variant="outlined">Add Annouchment</Button>
          </Grid>
        </Grid>


        </AccordionDetails>
      </Accordion>
   
      <DataGrid
        rows={tableData}
        columns={columns}
        pageSize={12}
      />
    <Snackbar open={open} autoHideDuration={6000} onClose={handleClose}>
        <Alert
          onClose={handleClose}
          severity={alertSeverity}
          variant="filled"
          sx={{ width: '100%' }}
        >
          {alertMessage}
        </Alert>
      </Snackbar>
      
    </div>
  )
}

export default DataTable