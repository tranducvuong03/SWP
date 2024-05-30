import React, { useState } from 'react';
import axios from 'axios';

const Login = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');

  const handleSubmit = (event) => {
    event.preventDefault();

    const user = {
      username,
      password
    };

    axios.post('api/login', user)
     .then(res => {
        console.log(res);
        // Handle successful login
      })
     .catch(err => {
        console.log(err);
        // Handle error
      });
  }

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <label>
          Username:
          <input type="text" onChange={e => setUsername(e.target.value)} />
        </label>
        <br />
        <label>
          Password:
          <input type="password" onChange={e => setPassword(e.target.value)} />
        </label>
        <br />
        <button type="submit">Login</button>
      </form>
    </div>
  );
}

export default Login;