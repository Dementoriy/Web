import React from 'react';
import Chart from './components/Chart';

function App() {
  return (
    <div className="App">
      <Chart min={0.000001} max={2.5} delta={0.001}/>
    </div>
  );
}

export default App;
