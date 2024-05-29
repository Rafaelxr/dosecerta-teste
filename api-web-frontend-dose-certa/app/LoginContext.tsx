import React, { createContext, useContext, useState, useEffect } from 'react';

interface LoginContextData {
  isLoggedIn: boolean;
  login: () => void;
  logout: () => void;
}

const LoginContext = createContext<LoginContextData>({} as LoginContextData);

export const useLogin = () => {
  return useContext(LoginContext);
};

export const LoginProvider: React.FC<{ children: React.ReactNode }> = ({ children }) => {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  useEffect(() => {
    const token = localStorage.getItem('doseCertaToken');
    if (token) {
      setIsLoggedIn(true);
    }
  }, []); 

  const login = () => {
    setIsLoggedIn(true);
    localStorage.setItem('doseCertaToken', 'seu_token_aqui');
  };

  const logout = () => {
    localStorage.removeItem('doseCertaToken');
    setIsLoggedIn(false);
  };

  return (
    <LoginContext.Provider value={{ isLoggedIn, login, logout }}>
      {children}
    </LoginContext.Provider>
  );
};
