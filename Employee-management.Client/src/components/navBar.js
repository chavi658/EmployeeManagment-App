
import React from 'react';
import { styled, alpha } from '@mui/material/styles';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import MenuIcon from '@mui/icons-material/Menu';
import MenuItem from '@mui/material/MenuItem';
import Menu from '@mui/material/Menu';
import { FaPlus, FaFileExcel, FaBars, FaHome } from 'react-icons/fa';
import { useNavigate } from 'react-router-dom';

const StyledMenuItem = styled(MenuItem)(({ theme }) => ({
  '&:hover': {
    backgroundColor: theme.palette.primary.main,
    color: theme.palette.primary.contrastText,
  },
}));

export default function NavBar({ onAdd, onExport }) {
  const [anchorEl, setAnchorEl] = React.useState(null);
  const navigate = useNavigate()
  const handleMenu = (event) => {
    setAnchorEl(event.currentTarget);
  };

  const handleClose = () => {
    setAnchorEl(null);
  };
  const onMenue = () => {
    navigate("/AllEmployees")
  }

  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar>
          <Typography
            variant="h6"
            noWrap
            component="div"
            sx={{ flexGrow: 1, textAlign: 'left' }} // שינוי כאן
          >
            <img src="https://upload.wikimedia.org/wikipedia/he/thumb/6/63/Cal_logo_2019.svg/1200px-Cal_logo_2019.svg.png" alt="logo" style={{ width: '60px', marginRight: '10px' }}></img> {/* שינוי כאן */}
          </Typography>
          <IconButton
            size="large"
            edge="start"
            color="inherit"
            aria-label="open drawer"
            aria-controls="menu-appbar"
            aria-haspopup="true"
            onClick={handleMenu}
            sx={{ mr: 2 }}
          >
            <MenuIcon />
          </IconButton>
          <Menu
            id="menu-appbar"
            anchorEl={anchorEl}
            anchorOrigin={{
              vertical: 'top',
              horizontal: 'right',
            }}
            keepMounted
            transformOrigin={{
              vertical: 'top',
              horizontal: 'right',
            }}
            open={Boolean(anchorEl)}
            onClose={handleClose}
          >
            <StyledMenuItem onClick={onAdd}>
              <FaPlus />
              Add Employee
            </StyledMenuItem>
            <StyledMenuItem onClick={onExport}>
              <FaFileExcel />
              Download to Excel
            </StyledMenuItem>
            <StyledMenuItem onClick={onMenue}>
              <FaHome />
              Back To The Main Menu
            </StyledMenuItem>

          </Menu>
        </Toolbar>
      </AppBar>
    </Box>
  );
}
