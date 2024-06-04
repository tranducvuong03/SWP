
import './App.css';
import Header from './components/Header';
import Footer from './components/Footer';
import Home from './pages/customer/Home';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Nhan from './pages/customer/Products/Nhan';
import Day_chuyen from './pages/customer/Products/Day_chuyen';
import Vong_tay from './pages/customer/Products/Vong_tay';
import Kim_cuong from './pages/customer/Products/Kim_cuong';
import About_us from './pages/customer/About_us';
import Chinh_sach from './pages/customer/Chinh_sach';
import Wishlist from './pages/customer/Wishlist';
import Dang_nhap from './Login/Dang_nhap';
import Dang_ki from './Login/Dang_ki';
import Thong_tin_tk from './Login/Thong_tin_tk';
import Chi_tiet_san_pham from './pages/customer/Products/Chi_tiet_san_pham';
import Lien_he from './pages/customer/Lien_he';
import Gio_hang from './pages/cart/Gio_hang';

function App() {
  return (
    <div>
      <Router>
        <Header />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/Nhan" element={<Nhan />} />
          <Route path='/Daychuyen'element={<Day_chuyen />} />
          <Route path='/Vongtay'element={<Vong_tay />} />
          <Route path='/Kimcuong'element={<Kim_cuong />} />
          <Route path='/Vechungtoi'element={<About_us />} />
          <Route path='/Chinhsach'element={<Chinh_sach />} />
          <Route path='/Yeuthich'element={<Wishlist />} />
          <Route path='/Dangnhap'element={<Dang_nhap />} />
          <Route path='/Dangki'element={<Dang_ki />} />
          <Route path='/Thongtintk'element={<Thong_tin_tk />} />
          <Route path='/Chitietsanpham'element={<Chi_tiet_san_pham />} />
          <Route path='/Lienhe'element={<Lien_he />} />
          <Route path='/Giohang'element={<Gio_hang />} />
         
        </Routes>

        <Footer />
      </Router>



    </div>



  );
}

export default App;
