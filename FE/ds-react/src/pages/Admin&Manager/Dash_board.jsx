// import React from 'react';

// export default function Dash_board() {
//   return (
//     <div>
//       <div className="wrapper">
//         <nav id="sidebar" className="sidebar js-sidebar">
//           <div className="sidebar-content js-simplebar">
//             <a className="sidebar-link" href="/dashboard">
//               <span className="align-middle">
//                 <img src="~/image/Logo.png" alt="" />
//               </span>
//             </a>

//             <ul className="sidebar-nav">
//               <li className="sidebar-header">
//                 Trang chủ
//               </li>

//               <li className="sidebar-item active">
//                 <a className="sidebar-link" href="/dashboard">
//                   <i className="align-middle" data-feather="sliders"></i> <span className="align-middle">Bảng điều khiển</span>
//                 </a>
//               </li>

//               <li className="sidebar-header">
//                 Quản lý
//               </li>

//               <li className="sidebar-item">
//                 <a className="sidebar-link" href="/products">
//                   <i className="align-middle" data-feather="square"></i> <span className="align-middle">Sản phẩm</span>
//                 </a>
//               </li>

//               <li className="sidebar-item">
//                 <a className="sidebar-link" href="/accounts">
//                   <i className="align-middle" data-feather="square"></i> <span className="align-middle">Tài khoản</span>
//                 </a>
//               </li>

//               <li className="sidebar-item">
//                 <a className="sidebar-link" href="/orders">
//                   <i className="align-middle" data-feather="square"></i> <span className="align-middle">Đơn hàng</span>
//                 </a>
//                 <a className="sidebar-link" href="/certifications">
//                   <i className="align-middle" data-feather="check-square"></i> <span className="align-middle">Chứng nhận sản phẩm</span>
//                 </a>
//               </li>

//               <li className="sidebar-item">
//                 <a className="sidebar-link" href="ui-cards.html">
//                   <i className="align-middle" data-feather="grid"></i> <span className="align-middle">Order</span>
//                 </a>
//               </li>
//             </ul>
//           </div>
//         </nav>
//       </div>

//       <div className="main">
//         <nav className="navbar navbar-expand navbar-light navbar-bg">
//           <a className="sidebar-toggle js-sidebar-toggle">
//             <i className="hamburger align-self-center"></i>
//           </a>

//           <div className="navbar-collapse collapse">
//             <ul className="navbar-nav navbar-align">
//               <li className="nav-item dropdown">
//                 <a className="nav-icon dropdown-toggle" href="#" id="alertsDropdown" data-bs-toggle="dropdown">
//                   <div className="position-relative">
//                     <i className="align-middle" data-feather="bell"></i>
//                     <span className="indicator">4</span>
//                   </div>
//                 </a>
//                 <div className="dropdown-menu dropdown-menu-lg dropdown-menu-end py-0" aria-labelledby="alertsDropdown">
//                   <div className="dropdown-menu-header">
//                     4 New Notifications
//                   </div>
//                   <div className="list-group">
//                     <a href="#" className="list-group-item">
//                       <div className="row g-0 align-items-center">
//                         <div className="col-2">
//                           <i className="text-danger" data-feather="alert-circle"></i>
//                         </div>
//                         <div className="col-10">
//                           <div className="text-dark">Update completed</div>
//                           <div className="text-muted small mt-1">Restart server 12 to complete the update.</div>
//                           <div className="text-muted small mt-1">30m ago</div>
//                         </div>
//                       </div>
//                     </a>
//                     <a href="#" className="list-group-item">
//                       <div className="row g-0 align-items-center">
//                         <div className="col-2">
//                           <i className="text-warning" data-feather="bell"></i>
//                         </div>
//                         <div className="col-10">
//                           <div className="text-dark">Lorem ipsum</div>
//                           <div className="text-muted small mt-1">Aliquam ex eros, imperdiet vulputate hendrerit et.</div>
//                           <div className="text-muted small mt-1">2h ago</div>
//                         </div>
//                       </div>
//                     </a>
//                     <a href="#" className="list-group-item">
//                       <div className="row g-0 align-items-center">
//                         <div className="col-2">
//                           <i className="text-primary" data-feather="home"></i>
//                         </div>
//                         <div className="col-10">
//                           <div className="text-dark">Login from 192.186.1.8</div>
//                           <div className="text-muted small mt-1">5h ago</div>
//                         </div>
//                       </div>
//                     </a>
//                     <a href="#" className="list-group-item">
//                       <div className="row g-0 align-items-center">
//                         <div className="col-2">
//                           <i className="text-success" data-feather="user-plus"></i>
//                         </div>
//                         <div className="col-10">
//                           <div className="text-dark">New connection</div>
//                           <div className="text-muted small mt-1">Christina accepted your request.</div>
//                           <div className="text-muted small mt-1">14h ago</div>
//                         </div>
//                       </div>
//                     </a>
//                   </div>
//                   <div className="dropdown-menu-footer">
//                     <a href="#" className="text-muted">Show all notifications</a>
//                   </div>
//                 </div>
//               </li>
//               <li className="nav-item dropdown">
//                 <a className="nav-icon dropdown-toggle d-inline-block d-sm-none" href="#" data-bs-toggle="dropdown">
//                   <i className="align-middle" data-feather="settings"></i>
//                 </a>

//                 <a className="nav-link dropdown-toggle d-none d-sm-inline-block" href="#" data-bs-toggle="dropdown">
//                   <img src="~/image/LeftNavBar/avatars/avatar.jpg" className="avatar img-fluid rounded me-1" alt="Charles Hall" /> <span className="text-dark">Charles Hall</span>
//                 </a>
//                 <div className="dropdown-menu dropdown-menu-end">
//                   <a className="dropdown-item" href="pages-profile.html"><i className="align-middle me-1" data-feather="user"></i>Thông tin cá nhân</a>
//                   <a className="dropdown-item" href="#"><i className="align-middle me-1" data-feather="pie-chart"></i> Phân tích</a>
//                   <div className="dropdown-divider"></div>
//                   <a className="dropdown-item" href="index.html"><i className="align-middle me-1" data-feather="settings"></i> Cài đặt và bảo mật</a>
//                   <a className="dropdown-item" href="#"><i className="align-middle me-1" data-feather="help-circle"></i> Trung tâm trợ giúp</a>
//                   <div className="dropdown-divider"></div>
//                   <a className="dropdown-item" href="/home">Đăng xuất</a>
//                 </div>
//               </li>
//             </ul>
//           </div>
//         </nav>
//       </div>
//     </div>
//   )
// }
