
import './employeeDetails.css'
import { useSelector } from "react-redux";
import "./employeeDetails"; // ייבוא קובץ CSS עם הגדרות העיצוב

const EmployeeDetails = () => {
    const employee = useSelector(state => state.employee);
    console.log("demp", employee);
    return (
        <>
            <div className="employee-details-container">
                <div className="employee-detail">
                    <span className="detail-label">employeeId:</span>
                    <h3 className="detail-value">{employee?.employeeId}</h3>
                </div>
                <div className="employee-detail">
                    <span className="detail-label">employeeFirstName:</span>
                    <h3 className="detail-value">{employee?.firstName}</h3>
                </div>
                <div className="employee-detail">
                    <span className="detail-label">employeeLastName:</span>
                    <h3 className="detail-value">{employee?.lastName}</h3>
                </div>
                <div className="employee-detail">
                    <span className="detail-label">DateOfBirth:</span>
                    <h3 className="detail-value">{employee?.dateOfBirth}</h3>
                </div>
                <div className="employee-detail">
                    <span className="detail-label">Gender:</span>
                    <h3 className="detail-value">{employee?.gender}</h3>
                </div>
                <div className="employee-detail">
                    <span className="detail-label">Roles:</span>
                    {employee?.roleList?.map(role => (
                        <div key={role.roleId} className="role-detail">
                            <span className="sub-detail-label">DataEntry:</span>
                            <h3 className="sub-detail-value">{role.dateOfRoleEntry}</h3>
                            <span className="sub-detail-label">RoleName:</span>
                            <h3 className="sub-detail-value">{role.roleName}</h3>
                        </div>
                    ))}
                </div>
            </div>
        </>
    );
};

export default EmployeeDetails;
