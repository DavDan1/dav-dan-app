import React, { useState } from 'react';

interface ChuckNorrisJokeProps {
  getJoke: () => Promise<string>;
}

const ChuckNorrisJoke: React.FC<ChuckNorrisJokeProps> = ({ getJoke }) => {
  const [joke, setJoke] = useState<string>('');

  const generateJoke = async () => {
    const newJoke = await getJoke();
    setJoke(newJoke);
    console.log(newJoke)
  };

  return (
    <div>
      <h1>Chuck Norris Joke Generator by Dav Dan</h1>
      <button onClick={generateJoke}>Generate Joke</button>
      {joke && <p>{joke}</p>}
    </div>
  );
};

export default ChuckNorrisJoke;
