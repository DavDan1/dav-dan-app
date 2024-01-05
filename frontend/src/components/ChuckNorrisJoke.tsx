import React, { useState } from 'react';
import axios from 'axios';

const ChuckNorrisJoke = () => {
    const [joke, setJoke] = useState('');

    const getJoke = async () => {
        try {
            const response = await axios.get('http://0.0.0.0:8080');
            setJoke(response.data.value);
            console.log(response.data.value)
        } catch (error) {
            console.error('Error fetching data:', error);
            setJoke('Failed to fetch Chuck Norris Joke');
        }
    };

    return (
        <div>
            <h1>Chuck Norris Joke Generator</h1>
            <button onClick={getJoke}>Generate Joke</button>
            {joke && <p>{joke}</p>}
        </div>
    );
};

export default ChuckNorrisJoke;
