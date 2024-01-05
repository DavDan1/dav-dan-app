import React, { useState } from 'react';
import axios from 'axios';

const ChuckNorrisJoke = () => {
    const [joke, setJoke] = useState('');

    const getJoke = async () => {
        try {
            const response = await axios.get('https://weather-app-davitdanielyan-e3uzzxqbva-uc.a.run.app/api/ChuckNorris/jokes/random');
            setJoke(response.data.value);
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
