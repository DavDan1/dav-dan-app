import ChuckNorrisJoke from '../components/ChuckNorrisJoke';

const IndexPage: React.FC = () => {
  const getJoke = async (): Promise<string> => {
    const response = await fetch('https://weather-app-davitdanielyan-e3uzzxqbva-uc.a.run.app');
    const data = await response.json();
    return data;
  };

  return <ChuckNorrisJoke getJoke={getJoke} />;
};

export default IndexPage;
