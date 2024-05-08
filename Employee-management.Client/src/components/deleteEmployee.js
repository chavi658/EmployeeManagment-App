
import { useLocation, useNavigate } from "react-router-dom"
import axios from "axios";
import { useDispatch, useSelector } from "react-redux";
import { useEffect } from "react"
import Swal from "sweetalert2";


const DeleteEmployee = () => {
    const dispatch = useDispatch();
    const { state } = useLocation();
    const navigate = useNavigate();
    useEffect(() => {
        axios.delete(`https://localhost:7094/api/Employee/${state.id}`)
            .then(x => {
                Swal.fire({
                    position: 'center',
                    icon: "success",
                    title: `The employee ${state.firstName} was deleted `,
                    showConfirmButton: false,
                    timer: 1500
                });
                navigate("/AllEmployees")
            })
            .catch(err => console.log(err))
            .finally()
    }, [])

}
export default DeleteEmployee;

