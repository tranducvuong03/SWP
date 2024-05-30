import React from 'react'

export default function Header() {
  return (
    <div className="header-area header-wide bg-gray">
        
        <div className="main-header d-none d-lg-block">
           
           
            <div className="header-main-area sticky">
                <div className="container">
                    <div className="row align-items-center position-relative">

                      
                        <div className="col-lg-2">
                            <div className="logo">
                                <a href="home-page.html">
                                    <img src="assets/img/logo/logo.png" alt="brand logo"/>
                                </a>
                            </div>
                        </div>
                       

                       
                        <div className="col-lg-6 position-static">
                            <div className="main-menu-area">
                                <div className="main-menu">
                                
                                    <nav className="desktop-menu">
                                        <ul>
                                            <li className="active"><a href="home-page.html"> Trang chủ </a>
                                            </li>
                                            <li><a href="shop.html"> Trang sức <i className="fa fa-angle-down"></i></a>
                                                <ul className="dropdown">
                                                    <li><a href="shop.html"> Nhẫn </a>
                                                        
                                                    </li>
                                                    <li><a href="shop.html"> Dây chuyền </a>
                                                       
                                                    </li>
                                                    <li><a href="shop.html"> Vòng tay </a>
                                                       
                                                    </li>
                                                    
                                                </ul>
                                            </li>
                                            <li><a href="shop.html"> Kim cương </a>
                                                       
                                            </li>
                                          
                                            <li><a href="shop.html"> Bảng giá kim cương </a>
                                                       
                                            </li>
                                            <li><a href="contact-us.html">Về chúng tôi</a></li>
                                        </ul>
                                    </nav> 
                                
                                </div>
                            </div>
                        </div>
                       

                       
                        <div className="col-lg-4">
                            <div className="header-right d-flex align-items-center justify-content-xl-between justify-content-lg-end">
                                <div className="header-search-container">
                                    <button className="search-trigger d-xl-none d-lg-block"><i className="pe-7s-search"></i></button>
                                    <form className="header-search-box d-lg-none d-xl-block">
                                        <input type="text" placeholder="Tìm kiếm sản phẩm" className="header-search-field bg-white"/>
                                        <button className="header-search-btn"><i className="pe-7s-search"></i></button>
                                    </form>
                                </div>
                                <div className="header-configure-area">
                                    <ul className="nav justify-content-end">
                                       
                                        <li className="user-hover">
                                            <a href="#">
                                                <i className="pe-7s-user"></i>
                                            </a>
                                            <ul className="dropdown-list">
                                                <li><a href="login-register.html">Đăng nhập</a></li>
                                                <li><a href="login-register.html">Đăng kí</a></li>
                                                <li><a href="my-account.html">Thông tin tài khoản</a></li>
                                            </ul>
                                        </li>
                                       
                                        <li>
                                            <a href="wishlist.html">
                                                <i className="pe-7s-like"></i>
                                                <div className="notification">0</div>
                                            </a>
                                        </li>

                                        <li>
                                            <a href="#" className="minicart-btn">
                                                <i className="pe-7s-shopbag"></i>
                                                <div className="notification">2</div>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>


                    </div>
                </div>
            </div>
          
        </div>
       
        <div className="mobile-header d-lg-none d-md-block sticky">
            
            <div className="container-fluid">
                <div className="row align-items-center">
                    <div className="col-12">
                        <div className="mobile-main-header">
                            <div className="mobile-logo">
                                <a href="home-page.html">
                                    <img src="assets/img/logo/logo.png" alt="Brand Logo"/>
                                </a>
                            </div>
                            <div className="mobile-menu-toggler">
                                <div className="mini-cart-wrap">
                                    <a href="cart.html">
                                        <i className="pe-7s-shopbag"></i>
                                        <div className="notification">0</div>
                                    </a>
                                </div>
                                <button className="mobile-menu-btn">
                                    <span></span>
                                    <span></span>
                                    <span></span>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           
        </div>
       
        <aside className="off-canvas-wrapper">
            <div className="off-canvas-overlay"></div>
            <div className="off-canvas-inner-content">
                <div className="btn-close-off-canvas">
                    <i className="pe-7s-close"></i>
                </div>

                <div className="off-canvas-inner">
                   
                    <div className="search-box-offcanvas">
                        <form>
                            <input type="text" placeholder="Tìm kiếm sản phẩm"/>
                            <button className="search-btn"><i className="pe-7s-search"></i></button>
                        </form>
                    </div>
                  
                    <div className="mobile-navigation">

                      
                        <nav>
                            <ul className="mobile-menu">
                              
                                <li className="menu-item-has-children"><a href="home-page.html">Trang chủ</a> </li> 
                            
                                <li className="menu-item-has-children "><a href="shop.html">Trang sức</a>
                                    <ul className="dropdown">
                                        <li className="menu-item-has-children"><a href="shop.html">Nhẫn</a>
                                           
                                        </li>
                                        <li className="menu-item-has-children"><a href="shop.html">Dây chuyền</a>
                                            
                                        </li>
                                        <li className="menu-item-has-children"><a href="shop.html">Vòng tay </a>
                                        </li>
                                        
                                    </ul>
                                </li>
                               
                                <li><a href="shop.html"> Kim cương </a>
                                                       
                                </li>
                            
                                <li><a href="shop.html"> Bảng giá kim cương </a>
                               
                                </li>
                                <li><a href="contact-us.html">Về chúng tôi</a></li>
                            </ul>
                        </nav>
                       
                    </div>
                    

                    <div className="mobile-settings">
                        <ul className="nav">
                            <li>
                                <div className="dropdown mobile-top-dropdown">
                                    <a href="#" className="dropdown-toggle" id="myaccount" data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        Tài khoản của tôi
                                        <i className="fa fa-angle-down"></i>
                                    </a>
                                    <div className="dropdown-menu" aria-labelledby="myaccount">
                                        <a className="dropdown-item" href="my-account.html">Thông tin tài khoản</a>
                                        <a className="dropdown-item" href="login-register.html"> Đăng nhập </a>
                                        <a className="dropdown-item" href="login-register.html"> Đăng kí </a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>

                   
                    <div className="offcanvas-widget-area">
                        <div className="off-canvas-contact-widget">
                            <ul>
                                <li><i className="fa fa-mobile"></i>
                                    <a href="#">0123456789</a>
                                </li>
                                <li><i className="fa fa-envelope-o"></i>
                                    <a href="#">info@yourdomain.com</a>
                                </li>
                            </ul>
                        </div>
                       
                    </div>
                 
                </div>
            </div>
        </aside>
       
    </div>
  )
}
