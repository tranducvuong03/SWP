import React from 'react'

export default function Footer() {
  return (
    <div className="footer-widget-area">
        <div className="footer-top section-padding">
            <div className="container">
                <div className="row">
                    <div className="col-lg-3 col-md-6">
                        <div className="widget-item">
                            <div className="widget-title">
                                <div className="widget-logo">
                                    <a href="index.html">
                                        <img src="assets/img/logo/logo.png" alt="brand logo"/>
                                    </a>
                                </div>
                            </div>
                            <div className="widget-body">
                                <p>We are a team of designers and developers that create high quality wordpress, shopify, Opencart </p>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-6">
                        <div className="widget-item">
                            <h6 className="widget-title">Contact Us</h6>
                            <div className="widget-body">
                                <address className="contact-block">
                                    <ul>
                                        <li><i className="pe-7s-home"></i> 4710-4890 Breckinridge USA</li>
                                        <li><i className="pe-7s-mail"></i> <a href="mailto:demo@plazathemes.com">demo@yourdomain.com </a></li>
                                        <li><i className="pe-7s-call"></i> <a href="tel:(012)800456789987">(012) 800 456 789-987</a></li>
                                    </ul>
                                </address>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-6">
                        <div className="widget-item">
                            <h6 className="widget-title">Information</h6>
                            <div className="widget-body">
                                <ul className="info-list">
                                    <li><a href="#">about us</a></li>
                                    <li><a href="#">Delivery Information</a></li>
                                    <li><a href="#">privet policy</a></li>
                                    <li><a href="#">Terms & Conditions</a></li>
                                    <li><a href="#">contact us</a></li>
                                    <li><a href="#">site map</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-6">
                        <div className="widget-item">
                            <h6 className="widget-title">Follow Us</h6>
                            <div className="widget-body social-link">
                                <a href="#"><i className="fa fa-facebook"></i></a>
                                <a href="#"><i className="fa fa-twitter"></i></a>
                                <a href="#"><i className="fa fa-instagram"></i></a>
                                <a href="#"><i className="fa fa-youtube"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="row align-items-center mt-20">
                    <div className="col-md-6">
                        <div className="newsletter-wrapper">
                            <h6 className="widget-title-text">Signup for newsletter</h6>
                            <form className="newsletter-inner" id="mc-form">
                                <input type="email" className="news-field" id="mc-email" autocomplete="off" placeholder="Enter your email address"/>
                                <button className="news-btn" id="mc-submit">Subscribe</button>
                            </form>
                            
                            <div className="mailchimp-alerts">
                                <div className="mailchimp-submitting"></div>
                                <div className="mailchimp-success"></div>
                                <div className="mailchimp-error"></div>
                            </div>
                           
                        </div>
                    </div>
                    <div className="col-md-6">
                        <div className="footer-payment">
                            <img src="assets/img/payment.png" alt="payment method"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div className="footer-bottom">
            <div className="container">
                <div className="row">
                    <div className="col-12">
                        <div className="copyright-text text-center">
                            <p>Copyright © 2024 ETERNAL SPARKLE DIAMOND STORE | Powered by Group 5 </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
  )
}
